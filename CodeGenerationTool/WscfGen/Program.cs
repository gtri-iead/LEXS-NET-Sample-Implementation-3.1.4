using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using Thinktecture.Tools.Web.Services.CodeGeneration;

namespace WscfGen
{
    class Program
    {
        static void PrintUsage()
        {
            System.Console.WriteLine("Usage: WscfGen /n:NameSpace /i:WsdlDir /o:OutputDir /server /separateFiles");
            System.Console.WriteLine("\t/n:Namespace   - Specify the code generated namespace.");
            System.Console.WriteLine("\t/i:WsdlDir     - Folder (relative path) where the WSDL"); 
            System.Console.WriteLine("\t                 file is located.");
            System.Console.WriteLine("\t/o:OutputDir   - Folder (relative path) where the generated");
            System.Console.WriteLine("\t                 files are to be stored.");
            System.Console.WriteLine("\t/server        - Generate service code. The default is to generate");
            System.Console.WriteLine("\t                 client proxy code.");
            System.Console.WriteLine("\t/separateFiles - Generates types as separate files. The default");
            System.Console.WriteLine("\t                 is to generate all types into a single file.");
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                PrintUsage();
                return;
            }

            try
            {
                string destinationNamespace = "Namespace";
                string wsdlLocation = string.Empty;
                string outputFolder = ".";
                bool isServer = false;
                bool separateFiles = false;

                foreach (string arg in args)
                {
                    if (arg.Substring(0, 2) == "/n")
                    {
                        destinationNamespace = arg.Substring(3);
                    }
                    else if (arg.Substring(0, 2) == "/i")
                    {
                        wsdlLocation = arg.Substring(3); ;
                    }
                    else if (arg.Substring(0, 2) == "/o")
                    {
                        outputFolder = arg.Substring(3); ;
                    }
                    else if (arg == "/server")
                    {
                        isServer = true;
                    }
                    else if (arg == "/separateFiles")
                    {
                        separateFiles = true;
                    }
                    else
                    {
                        PrintUsage();
                        return;
                    }
                }


                if (wsdlLocation == string.Empty)
                {
                    System.Console.WriteLine("Please specifi a WSDL file.");
                    PrintUsage();
                    return;
                }
                                
                CodeGenerator codeGen = new CodeGenerator();

                CodeGenerationOptions options = new CodeGenerationOptions();

                options.GenerateDataContracts = false;
                options.GenerateProperties = true;
                options.GenerateCollections = false;
                options.GenerateSeparateFiles = separateFiles;
                options.OverwriteExistingFiles = true;
                options.AdjustCasing = false;
                options.EnableDataBinding = false;
                options.GenerateOrderIdentifiers = true;
                options.GenerateTypedLists = false;

                options.ClrNamespace = destinationNamespace;
                options.OutputFileName = destinationNamespace + ".cs";
                options.OutputLocation = outputFolder;
                options.ProjectDirectory = outputFolder;

                // only support C# for now
                options.Language = CodeLanguage.CSharp;
                options.ConfigurationFile = "App.config";
                options.EnableWsdlEndpoint = false;
                options.FormatSoapActions = false;
                options.GenerateAsyncCode = false;
                options.GenerateService = isServer;

                options.GenerateSvcFile = true;
                options.ConcurrencyMode = "Single";
                options.InstanceContextMode = "PerCall";

                string wsdlFullPath = Path.GetFullPath(wsdlLocation);
                System.Console.WriteLine("Wsdl Full Path: " + wsdlFullPath);

                options.MetadataLocation = wsdlFullPath;
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
