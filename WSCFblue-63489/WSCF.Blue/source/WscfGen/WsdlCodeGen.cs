using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.CodeDom;
using System.ServiceModel.Channels;
using System.Web.Services.Description;
using System.Xml.Schema;
using System.Xml.Serialization;
using Microsoft.CSharp;


namespace WscfGen
{
    public class WsdlCodeGen
    {
        public string Assembly = null;
        public AppDomain LocalAppDomain = null;
        public string ErrorMessage = "";

        /// <summary>
        /// Generate proxy to the Web service.
        /// </summary>
        /// <param name="wsdlUrl"></param>
        /// <param name="generatedSourceFilename"></param>
        /// <param name="generatedNamespace"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool GenerateWsdlProxyClass(string wsdlUrl, string generatedSourceFilename,
            string generatedNamespace, string username, string password)
        {
            // erase the source file
            if (File.Exists(generatedSourceFilename))
                File.Delete(generatedSourceFilename);

            // download the WSDL content into a service description
            WebClient http = new WebClient();
            System.Web.Services.Description.ServiceDescription sd = null;

            if (!string.IsNullOrEmpty(username))
                http.Credentials = new NetworkCredential(username, password);

            try
            {
                sd = System.Web.Services.Description.ServiceDescription.Read(http.OpenRead(wsdlUrl));
            }
            catch (Exception ex)
            {
                this.ErrorMessage = "Wsdl Download failed: " + ex.Message;
                return false;
            }

            // create an importer and associate with the ServiceDescription
            ServiceDescriptionImporter importer = new ServiceDescriptionImporter();
            importer.ProtocolName = "SOAP";
            importer.CodeGenerationOptions = CodeGenerationOptions.None;
            importer.AddServiceDescription(sd, null, null);

            // Download and inject any imported schemas (ie. WCF generated WSDL)            
            foreach (XmlSchema wsdlSchema in sd.Types.Schemas)
            {
                // Loop through all detected imports in the main schema
                foreach (XmlSchemaObject externalSchema in wsdlSchema.Includes)
                {
                    // Read each external schema into a schema object and add to importer
                    if (externalSchema is XmlSchemaImport)
                    {
                        Uri baseUri = new Uri(wsdlUrl);
                        Uri schemaUri = new Uri(baseUri, ((XmlSchemaExternal)externalSchema).SchemaLocation);

                        Stream schemaStream = http.OpenRead(schemaUri);
                        System.Xml.Schema.XmlSchema schema = XmlSchema.Read(schemaStream, null);
                        importer.Schemas.Add(schema);
                    }
                }
            }

            // set up for code generation by creating a namespace and adding to importer
            CodeNamespace ns = new CodeNamespace(generatedNamespace);
            CodeCompileUnit ccu = new CodeCompileUnit();
            ccu.Namespaces.Add(ns);
            importer.Import(ns, ccu);

            // final code generation in specified language
            CSharpCodeProvider provider = new CSharpCodeProvider();
            System.CodeDom.Compiler.IndentedTextWriter tw = new System.CodeDom.Compiler.IndentedTextWriter(new StreamWriter(generatedSourceFilename));
            provider.GenerateCodeFromCompileUnit(ccu, tw, new System.CodeDom.Compiler.CodeGeneratorOptions());

            tw.Close();

            return File.Exists(generatedSourceFilename);
        }

    }
}
