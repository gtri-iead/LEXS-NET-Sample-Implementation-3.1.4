using System;
using System.Collections;
using System.Collections.Generic;
using System.CodeDom;
using System.ServiceModel.Description;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Text;
using System.IO;


namespace Thinktecture.Tools.Web.Services.CodeGeneration.Decorators
{
    internal class MissingTypesDecorator : ICodeDecorator, IMetadata
    {
        #region private members

        MetadataSet metadataSet = null;

        #endregion

        #region ICodeDecorator Members

        /// <summary>
        /// Decorates the specified code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="options">The options.</param>
        public void Decorate(ExtendedCodeDomTree code, CustomCodeGenerationOptions options)
        {
            DecorateCodeNamespace(code.CodeNamespace);
        }

        #endregion

        #region IMetadata Members

        public MetadataSet MetadataSet
        {
            set { this.metadataSet = value; }
        }

        #endregion

        #region Private Methods
        private XmlQualifiedName GetCodeTypeXmlQName(CodeTypeDeclaration ctd)
        {
            string typeNamespace = string.Empty;
            string typeName = ctd.Name;

            // get XML namespace (probably need the name too)
            foreach (CodeAttributeDeclaration tda in ctd.CustomAttributes)
            {
                // only interested in head elements
                if (tda.Name == "System.Xml.Serialization.XmlTypeAttribute")
                {
                    foreach (CodeAttributeArgument caa in tda.Arguments)
                    {
                        if (caa.Name == "TypeName")
                        {
                            CodePrimitiveExpression cpe = caa.Value as CodePrimitiveExpression;

                            if (cpe != null)
                            {
                                typeName = cpe.Value.ToString();
                            }
                        }
                        else if (caa.Name == "Namespace")
                        {
                            CodePrimitiveExpression cpe = caa.Value as CodePrimitiveExpression;

                            if (cpe != null)
                            {
                                typeNamespace = cpe.Value.ToString();
                            }
                        }
                    }
                }
            }

            return new XmlQualifiedName(typeName, typeNamespace);
        }

        private void DecorateCodeNamespace(CodeNamespace codeNamespace)
        {
            // Generate the schema set code namespace
            CodeNamespace schemaSetCodeNamespace = GenerateSchemaTypes();
            
            // Add the code namespace to a fast search structure
            //      KeyValuePair<type  , namespace> 
            HashSet<KeyValuePair<string, string>> typeSet = new System.Collections.Generic.HashSet<KeyValuePair<string, string>>();
            
            foreach (CodeTypeDeclaration ctd in codeNamespace.Types)
            {
                XmlQualifiedName typeQn = GetCodeTypeXmlQName(ctd);

                typeSet.Add(new KeyValuePair<string, string>(typeQn.Name, typeQn.Namespace));
            }
            
            // add the missing types from the schema code namespace to the main code namespace
            foreach (CodeTypeDeclaration sctd in schemaSetCodeNamespace.Types)
            {
                XmlQualifiedName typeQn = GetCodeTypeXmlQName(sctd);

                if (!typeSet.Contains(new KeyValuePair<string, String>(typeQn.Name, typeQn.Namespace)))
                {
                    codeNamespace.Types.Add(sctd);
                }
            }
        }

        private CodeNamespace GenerateSchemaTypes()
        {
            CodeNamespace cns = new CodeNamespace();

            // add the schemas to a Schemas collection used by the XmlSchemImporter
            XmlSchemas importSchemas = new XmlSchemas();
            foreach (MetadataSection mds in metadataSet.MetadataSections)
            {
                XmlSchema xsd = mds.Metadata as XmlSchema;
                if (xsd != null)
                {
                    importSchemas.Add(xsd);
                }
            }

            XmlSchemaImporter imp = new XmlSchemaImporter(importSchemas);

            XmlCodeExporter exp = new XmlCodeExporter(cns);

            foreach (XmlSchema xsd in importSchemas)
            {
                // Iterate schema items (top-level elements only) and generate code for each
                foreach (XmlSchemaObject item in xsd.Items)
                {
                    if (item is XmlSchemaElement)
                    {
                        // Import the mapping first
                        XmlTypeMapping map = imp.ImportTypeMapping(
                          new XmlQualifiedName(((XmlSchemaElement)item).Name, xsd.TargetNamespace));

                        // Finally, export the code 
                        exp.ExportTypeMapping(map);
                    }
                }
            }
            
            return cns;
        }


        #endregion
    }
}
