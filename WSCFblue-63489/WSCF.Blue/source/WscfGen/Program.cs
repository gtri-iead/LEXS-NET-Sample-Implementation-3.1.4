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
using Microsoft.CSharp;

using Thinktecture.Tools.Web.Services.CodeGeneration;

namespace WscfGen
{

    class Program
    {
        static void PrintUsage()
        {
            System.Console.WriteLine("Usage: WscfGen /n:NameSpace /i:WsdlFolder /o:OutputFolder.");
        }

        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                PrintUsage();
                return;
            }

            try
            {
                string destinationNamespace = args[0].Substring(3);
                string wsdlLocation = args[1].Substring(3);
                string outputFolder = args[2].Substring(3); ;

                CodeGenerator codeGen = new CodeGenerator();

                CodeGenerationOptions options = new CodeGenerationOptions();

                options.GenerateDataContracts = false;
                options.GenerateProperties = true;
                options.GenerateCollections = false;
                options.GenerateSeparateFiles = false;
                options.OverwriteExistingFiles = true;
                options.AdjustCasing = false;
                options.EnableDataBinding = false;
                options.GenerateOrderIdentifiers = true;
                options.GenerateTypedLists = true;

                options.ClrNamespace = destinationNamespace;
                options.OutputFileName = destinationNamespace + ".cs";
                options.OutputLocation = outputFolder;
                options.ProjectDirectory = outputFolder;

                options.Language = CodeLanguage.CSharp;
                options.ConfigurationFile = "App.config";
                options.EnableWsdlEndpoint = false;
                options.FormatSoapActions = false;
                options.GenerateAsyncCode = false;

                options.GenerateService = false;

                options.GenerateSvcFile = true;
                options.ConcurrencyMode = "Single";
                options.InstanceContextMode = "PerCall";
                options.MetadataLocation = wsdlLocation;
                options.MethodImplementation = MethodImplementation.NotImplementedException;
                options.UseSynchronizationContext = true;


                codeGen.GenerateCode(options);
            }
            catch (Exception e)
            {
                System.Console.WriteLine("Exception: " + e.Message);

                PrintUsage();
            }
        }
    }
}
