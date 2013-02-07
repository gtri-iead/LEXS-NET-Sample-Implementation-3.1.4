﻿using System.CodeDom;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Configuration;
using System.ServiceModel.Description;

using Binding = System.ServiceModel.Channels.Binding;

namespace Thinktecture.Wscf.Framework.CodeGeneration
{
	/// <summary>
	/// Generates a <see cref="CodeCompileUnit"/> from a metadata set.
	/// </summary>
	public class CodeGenerator : ICodeGenerator
	{
		private readonly IWsdlImporterBuilder wsdlImporterBuilder;
		private readonly IServiceContractGeneratorBuilder serviceContractGeneratorBuilder;

		/// <summary>
		/// Initializes a new instance of the <see cref="CodeGenerator"/> class.
		/// </summary>
		/// <param name="wsdlImporterBuilder">The WSDL importer builder.</param>
		/// <param name="serviceContractGeneratorBuilder">The service contract generator builder.</param>
		public CodeGenerator(IWsdlImporterBuilder wsdlImporterBuilder, IServiceContractGeneratorBuilder serviceContractGeneratorBuilder)
		{
			this.wsdlImporterBuilder = wsdlImporterBuilder;
			this.serviceContractGeneratorBuilder = serviceContractGeneratorBuilder;
		}

		/// <summary>
		/// Generates the <see cref="CodeCompileUnit"/> based on the provide context.
		/// </summary>
		/// <param name="codeGeneratorContext">The code generator context.</param>
		/// <returns>A <see cref="CodeCompileUnit"/> containing the generated code.</returns>
		public CodeCompileUnit GenerateCode(ICodeGeneratorContext codeGeneratorContext)
		{
			WsdlImporter wsdlImporter = wsdlImporterBuilder.Build(codeGeneratorContext);
			ServiceContractGenerator contractGenerator = serviceContractGeneratorBuilder.Build(codeGeneratorContext);

			GenerateCodeDomTree(wsdlImporter, contractGenerator);

			//TODO:Alex:Generate the Configuration information and merge if required.
			
			//TODO:Alex:Prevent the need to keep all types in the same namespaces for certain code decorators.

			return contractGenerator.TargetCompileUnit;
		}

		private static void GenerateCodeDomTree(WsdlImporter wsdlImporter, ServiceContractGenerator contractGenerator)
		{
			Collection<ContractDescription> contracts = wsdlImporter.ImportAllContracts();
			Collection<Binding> bindings = wsdlImporter.ImportAllBindings();
			ServiceEndpointCollection endpoints = wsdlImporter.ImportAllEndpoints();

			if (wsdlImporter.Errors.Any(e => !e.IsWarning))
			{
				throw new CodeGenerationException(wsdlImporter.Errors);
			}

			foreach (ContractDescription contract in contracts)
			{
				//TODO:Alex:Make the naming scheme customisable.
				contract.Name = "I" + contract.Name.Replace("Interface", string.Empty);
				contractGenerator.GenerateServiceContractType(contract);
			}

			foreach (Binding binding in bindings)
			{
				string bindingSectionName, configurationName;
				contractGenerator.GenerateBinding(binding, out bindingSectionName, out configurationName);
			}

			foreach (ServiceEndpoint endpoint in endpoints)
			{
				ChannelEndpointElement channelElement;
				contractGenerator.GenerateServiceEndpoint(endpoint, out channelElement);
			}
		}
	}
}
