using System;
using System.Collections.Generic;
using System.CodeDom;
using System.ServiceModel.Description;
using System.Xml;
using System.Xml.Schema;
using System.Text;
using System.IO;
using System.Diagnostics;


namespace Thinktecture.Tools.Web.Services.CodeGeneration.Decorators
{   
     internal class SubstitutionGroupsDecorator : ICodeDecorator, IMetadata
    {
        #region private members

        public struct SubstitutionGroup
        {
            public string headElementName;
            public string headElementNamespace;
            public string headElementType;
            public string substitutableElementName;
            public string substitutableElementNamespace;
            public string substitutableElementType;
            public bool isNullable;
        }
        
        public struct SchemaTypeEx
        {
            public XmlQualifiedName _shemaType;

            //               <Head elem. QNAME, Subst. Groups>
            public Dictionary<XmlQualifiedName, List<SubstitutionGroup>> _headElements;
        }

        // Key = Schema Complex Type QNAME, Value =  SchemaTypeEx
        Dictionary<XmlQualifiedName, SchemaTypeEx> _schemaTypeElementsMap = null;
        
        // Key = head element, Value = list of subst. groups
        Dictionary<XmlQualifiedName, List<SubstitutionGroup>> _substGroupMapQualified = null;


        MetadataSet _metadataSet = null;
        #endregion

        #region CTOR

        public SubstitutionGroupsDecorator()
        {
            _substGroupMapQualified = new Dictionary<XmlQualifiedName, List<SubstitutionGroup>>();
            _schemaTypeElementsMap = new Dictionary<XmlQualifiedName, SchemaTypeEx>();
        }
        #endregion

        #region ICodeDecorator Members

        /// <summary>
        /// Decorates the specified code.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <param name="options">The options.</param>
        public void Decorate(ExtendedCodeDomTree code, CustomCodeGenerationOptions options)
        {
            // Get the substitution groups that are in different schema namespaces

            GenerateSubstGroupMap();

            GenerateSchemaTypeElementMap(_metadataSet);

            DecorateCodeNamespace(code.CodeNamespace);
        }

        #endregion

        #region IMetadata Members

        public MetadataSet MetadataSet
        {
            set { this._metadataSet = value; }
        }

        #endregion

        #region Private Methods

        public string ToCamelCase(string name)
        {
            if (name == null || name.Length == 0)
                return string.Empty;
            if (name.Length == 1)
                return name.ToLower();
            var firstChar = name.Substring(0, 1).ToLower();
            return firstChar + name.Substring(1, name.Length - 1);
        }

        public void GenerateSchemaTypeElementMap(MetadataSet metadataSet)
        {
            if (_schemaTypeElementsMap == null)
            {
                _schemaTypeElementsMap = new Dictionary<XmlQualifiedName, SchemaTypeEx>();
            }

            foreach (MetadataSection mds in metadataSet.MetadataSections)
            {
                XmlSchema xsd = mds.Metadata as XmlSchema;
                if (xsd != null)
                {
                    foreach (XmlSchemaType type in xsd.SchemaTypes.Values)
                    {
                        XmlSchemaComplexType complexType = type as XmlSchemaComplexType;
                        if (complexType != null && complexType.ContentModel is XmlSchemaComplexContent)
                        {
                            XmlSchemaSequence schemaSequence = complexType.ContentTypeParticle as XmlSchemaSequence;

                            if (schemaSequence == null)
                            {
                                continue;
                            }

                            // For now check the sequence particle
                            foreach (XmlSchemaObject schemaObj in schemaSequence.Items)
                            {
                                XmlSchemaElement schemaElem = schemaObj as XmlSchemaElement;
                                if (schemaElem != null)
                                {
                                    foreach (KeyValuePair<XmlQualifiedName, List<SubstitutionGroup>> headElemPair in _substGroupMapQualified)
                                    {
                                        // the head element qname and the schema element qname are the same, so the head element is declared
                                        // in the schema type
                                        if (headElemPair.Key == schemaElem.QualifiedName)
                                        {
                                            if (!_schemaTypeElementsMap.ContainsKey(complexType.QualifiedName))
                                            {
                                                SchemaTypeEx schemaType;
                                                schemaType._shemaType = complexType.QualifiedName;
                                                schemaType._headElements = new Dictionary<XmlQualifiedName, List<SubstitutionGroup>>();

                                                _schemaTypeElementsMap.Add(complexType.QualifiedName, schemaType);
                                            }

                                            if (!_schemaTypeElementsMap[complexType.QualifiedName]._headElements.ContainsKey(schemaElem.QualifiedName))
                                            {
                                                _schemaTypeElementsMap[complexType.QualifiedName]._headElements[schemaElem.QualifiedName] = headElemPair.Value;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private XmlQualifiedName GetCodeTypeXmlQualifiedName(CodeTypeDeclaration ctd)
        {
            string typeNamespace = string.Empty;
            string typeName = ctd.Name;

            // get XML name and namespace 
            foreach (CodeAttributeDeclaration tda in ctd.CustomAttributes)
            {
                // only interested in data contract attributes
                if (tda.Name == "System.Xml.Serialization.XmlTypeAttribute")
                {
                    foreach (CodeAttributeArgument caa in tda.Arguments)
                    {
                        CodePrimitiveExpression cpe = caa.Value as CodePrimitiveExpression;
                        if (cpe != null)
                        {
                            if (caa.Name == "TypeName")
                            {
                                typeName = cpe.Value.ToString();
                            }
                            else if (caa.Name == "Namespace")
                            {
                                typeNamespace = cpe.Value.ToString();
                            }
                        }
                    }
                }
            }

            return new XmlQualifiedName(typeName, typeNamespace);
        }

        private void GenerateSubstGroupMap()
        {
            StringWriter stringWriter = new StringWriter();

            if (_substGroupMapQualified == null)
            {
                _substGroupMapQualified = new Dictionary<XmlQualifiedName, List<SubstitutionGroup>>();
            }

            foreach (MetadataSection mds in _metadataSet.MetadataSections)
            {
                XmlSchema xsd = mds.Metadata as XmlSchema;
                if (xsd != null)
                {
                    foreach (XmlSchemaObject xso in xsd.Items)
                    {
                        if (xso is XmlSchemaElement)
                        {
                            XmlSchemaElement xse = xso as XmlSchemaElement;

                            if (xse.SubstitutionGroup != null && !xse.SubstitutionGroup.IsEmpty)
                            {
                                XmlQualifiedName elemQualName = new XmlQualifiedName(xse.SubstitutionGroup.Name, xse.SubstitutionGroup.Namespace);

                                SubstitutionGroup substGroup = new SubstitutionGroup();
                                substGroup.headElementName = xse.SubstitutionGroup.Name;
                                substGroup.headElementNamespace = xse.SubstitutionGroup.Namespace;
                                substGroup.headElementType = string.Empty;
                                substGroup.substitutableElementName = xse.QualifiedName.Name;
                                substGroup.substitutableElementNamespace = xse.QualifiedName.Namespace;
                                substGroup.isNullable = xse.IsNillable;

                                if (xse.ElementSchemaType.QualifiedName.Name.Length > 0)
                                {
                                    substGroup.substitutableElementType = xse.ElementSchemaType.QualifiedName.Name;
                                }

                                if (!_substGroupMapQualified.ContainsKey(elemQualName))
                                {
                                    _substGroupMapQualified[elemQualName] = new List<SubstitutionGroup>();
                                }

                                _substGroupMapQualified[elemQualName].Add(substGroup);
                            }
                        }
                    }
                }
            }
        }
        
        private bool SchemaTypeExists(CodeTypeDeclaration ctd)
        {
            XmlQualifiedName qn = GetCodeTypeXmlQualifiedName(ctd);

            if (_schemaTypeElementsMap.ContainsKey(qn))
            {
                return true;
            }

            return false;
        }

        List<XmlQualifiedName> GetXmlAttributes(string codeTypeNamespace, CodeTypeMemberExtension memberExt)
        {
            List<XmlQualifiedName> res = new List<XmlQualifiedName>();

            foreach (CodeAttributeDeclaration cad in memberExt.ExtendedObject.CustomAttributes)
            {
                if (cad.Name == "System.Xml.Serialization.XmlElementAttribute")
                {
                    string typeName = string.Empty;
                    string typeNamespace = codeTypeNamespace;
                    string elementName = string.Empty;

                    // initialize to the type namespace for the case where the element has no namespace
                    string elementNamespace = typeNamespace;

                    foreach (CodeAttributeArgument caa in cad.Arguments)
                    {
                        if (caa.Name == "Namespace")
                        {
                            CodePrimitiveExpression cpe = caa.Value as CodePrimitiveExpression;

                            if (cpe != null)
                            {
                                elementNamespace = cpe.Value.ToString();
                            }

                            continue;
                        }

                        CodePrimitiveExpression cpe2 = caa.Value as CodePrimitiveExpression;

                        if (cpe2 != null)
                        {
                            if (elementName == string.Empty)
                            {
                                // need to get the namespace
                                elementName = (cpe2.Value.ToString());
                            }
                        }
                    }

                    XmlQualifiedName qn = new XmlQualifiedName(elementName, typeNamespace);

                    res.Add(qn);
                }
            }
            return res;
        }

        int GetPropertyOrder(CodeTypeDeclaration ctd, CodeTypeMemberExtension memberExt)
        {
            int order = -1;
            int propOrder = -1;

            foreach (CodeTypeMember member in ctd.Members)
            {
                CodeTypeMemberExtension currMemberExt = member as CodeTypeMemberExtension;

                if (memberExt != null && memberExt.Kind == CodeTypeMemberKind.Property)
                {
                    foreach (CodeAttributeDeclaration cad in memberExt.ExtendedObject.CustomAttributes)
                    {
                        foreach (CodeAttributeArgument caa in cad.Arguments)
                        {
                            if (caa.Name == "Order")
                            {
                                CodePrimitiveExpression cpe = caa.Value as CodePrimitiveExpression;

                                if (cpe != null)
                                {
                                    order = (int)cpe.Value;
                                }

                            }
                        }
                    }

                    propOrder++;
                }
            }

            if (order != -1)
            {
                propOrder = order;
            }

            return propOrder;                
        }
               
        SchemaTypeEx GetSchemaType(XmlQualifiedName typeQn)
        {
            Debug.Assert(_schemaTypeElementsMap.ContainsKey(typeQn));

            return _schemaTypeElementsMap[typeQn];
        }

        List<SubstitutionGroup> GetSubstitutionGroups(SchemaTypeEx schemaType, List<XmlQualifiedName> xmlAttributes)
        {
            // First, find the head element that contains the xml attributes
            string headElementName = string.Empty;
            string headElementNamespace = string.Empty;
           
            foreach (KeyValuePair<XmlQualifiedName, List<SubstitutionGroup>> kvp in schemaType._headElements)
            {
                foreach (SubstitutionGroup sg in kvp.Value)
                {
                    XmlQualifiedName qn = new XmlQualifiedName(sg.substitutableElementName, sg.substitutableElementNamespace);

                    if (xmlAttributes.Find(
                        delegate(XmlQualifiedName qn1)
                        {
                            return qn == qn1;
                        }) != null)
                    {
                        headElementName = sg.headElementName;
                        headElementNamespace = sg.headElementNamespace;

                        break;
                    }
                }
            }

            // now return the List of SGs the belong to this head element
            XmlQualifiedName headElement = new XmlQualifiedName(headElementName, headElementNamespace);

            List<SubstitutionGroup> substGroups = null;
            if ( schemaType._headElements.ContainsKey(headElement) )
            {
                substGroups = schemaType._headElements[headElement];
            }

            return substGroups;
        }

        private void NormalizeCodeNamespaceTypes(CodeTypeDeclaration ctd, string propName)
        {
            // Need to preserve current XML attribute decorations
            // Need to change the CodeTypeMemberExtension's type and name
            Type objType = typeof(System.Object);
            CodeTypeReference objectRefType = new CodeTypeReference(objType);
            string fieldName = ToCamelCase(propName) + "Field";

            for (int j = 0; j < ctd.Members.Count; j++)
            {
                CodeTypeMemberExtension memberExt = ctd.Members[j] as CodeTypeMemberExtension;

                if (memberExt != null)
                {
                    // Process Property
                    if (memberExt.Kind == CodeTypeMemberKind.Property && memberExt.ExtendedObject.Name == propName)
                    {
                        CodeMemberProperty codeMemberProperty = memberExt.ExtendedObject as CodeMemberProperty;

                        if (codeMemberProperty != null)
                        {
                            codeMemberProperty.Type.BaseType = objectRefType.BaseType;
                        }
                    }

                    // Process Field
                    if (memberExt.Kind == CodeTypeMemberKind.Field && memberExt.ExtendedObject.Name == fieldName)
                    {
                        CodeMemberField codeMemberField = memberExt.ExtendedObject as CodeMemberField;

                        if (codeMemberField != null)
                        {
                            codeMemberField.Type.BaseType = objectRefType.BaseType;
                        }
                    }
                }
            }
        }

        private void DecorateCodeNamespace(CodeNamespace codeNamespace)
        {
            foreach (CodeTypeDeclaration ctd in codeNamespace.Types)
            {
                XmlQualifiedName typeQn = GetCodeTypeXmlQualifiedName(ctd);

                // Check that this schema type needs XML element attribute decoratino
                if (!SchemaTypeExists(ctd) )
                {
                    continue;
                }

                // Now get the schema type
                SchemaTypeEx schemaType = GetSchemaType(typeQn);
                                
                foreach (CodeTypeMember member in ctd.Members)
                {
                    CodeTypeMemberExtension memberExt = member as CodeTypeMemberExtension;
                    if (memberExt != null)
                    {
                        // get a list of the qualified attribute names (XmlElementAttribute) for this property

                        if ( memberExt.Kind == CodeTypeMemberKind.Property )
                        {
                            CodeMemberProperty codeMemberProperty = memberExt.ExtendedObject as CodeMemberProperty;

                            int propertyOrder = GetPropertyOrder(ctd, memberExt);

                            // get the XmlAttributes for this property
                            List<XmlQualifiedName> xmlAttributes = GetXmlAttributes(typeQn.Namespace, memberExt);

                            if (xmlAttributes != null && xmlAttributes.Count > 0)
                            {
                                // now, based on the property decorations, get the appropriate head element name

                                // Here I am getting an existing sg.
                                // Need a list of SGs that are not in the current list
                                List<SubstitutionGroup> substGroups = GetSubstitutionGroups(schemaType, xmlAttributes);

                                if (substGroups != null)
                                {
                                    foreach (SubstitutionGroup sg in substGroups)
                                    {
                                        bool attributeAlreadyExists = false;
                                        foreach (CodeAttributeDeclaration cad in memberExt.ExtendedObject.CustomAttributes)
                                        {
                                            foreach (CodeAttributeArgument caa in cad.Arguments)
                                            {
                                                CodePrimitiveExpression cpe = caa.Value as CodePrimitiveExpression;

                                                if (cpe != null)
                                                {
                                                    if (sg.substitutableElementName == cpe.Value.ToString())
                                                    {
                                                        attributeAlreadyExists = true;
                                                        break;
                                                    }
                                                }
                                            }
                                        }

                                        if (!attributeAlreadyExists && sg.substitutableElementName != null && sg.substitutableElementName.Length > 0)
                                        {
                                            CodeAttributeArgument[] args = new CodeAttributeArgument[5];
                                            args[0] = new CodeAttributeArgument(new CodePrimitiveExpression(sg.substitutableElementName));
                                            args[1] = new CodeAttributeArgument(new CodeTypeOfExpression(sg.substitutableElementType));
                                            args[2] = new CodeAttributeArgument("Namespace", new CodePrimitiveExpression(sg.substitutableElementNamespace));
                                            args[3] = new CodeAttributeArgument("IsNullable", new CodePrimitiveExpression(sg.isNullable));
                                            args[4] = new CodeAttributeArgument("Order", new CodePrimitiveExpression(propertyOrder));

                                            CodeAttributeDeclaration newCad = new CodeAttributeDeclaration("System.Xml.Serialization.XmlElementAttribute", args);
                                            memberExt.ExtendedObject.CustomAttributes.Add(newCad);

                                            // now make sure the modified property and field has their type changed to System.Object
                                            // to avoid serialization problems for type-less subst groups head elements
                                            NormalizeCodeNamespaceTypes(ctd, memberExt.ExtendedObject.Name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
      

      
            
        #endregion
    }
}


