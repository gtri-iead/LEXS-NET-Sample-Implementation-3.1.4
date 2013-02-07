using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.ServiceModel.Description;

namespace Thinktecture.Wscf.Framework.CodeGeneration
{
	/// <summary>
	/// A builder for creating <see cref="ServiceContractGenerator"/> instances.
	/// </summary>
	public class ServiceContractGeneratorBuilder : IServiceContractGeneratorBuilder
	{
		private readonly IServiceContractGenerationOptionsBuilder generationOptionsBuilder;

		/// <summary>
		/// Initializes a new instance of the <see cref="ServiceContractGeneratorBuilder"/> class.
		/// </summary>
		/// <param name="generationOptionsBuilder">The service contract generation options builder.</param>
		public ServiceContractGeneratorBuilder(IServiceContractGenerationOptionsBuilder generationOptionsBuilder)
		{
			this.generationOptionsBuilder = generationOptionsBuilder;
		}

		/// <summary>
		/// Builds a new instance.
		/// </summary>
		/// <param name="codeGeneratorContext">The code generator context.</param>
		/// <returns>
		/// A new <see cref="ServiceContractGenerator"/> instance.
		/// </returns>
		public ServiceContractGenerator Build(ICodeGeneratorContext codeGeneratorContext)
		{
			CodeGeneratorOptions codeGeneratorOptions = codeGeneratorContext.CodeGeneratorOptions;
			CodeCompileUnit codeCompileUnit = codeGeneratorContext.CodeCompileUnit;
			Configuration configuration = InitializeConfiguration();

			ServiceContractGenerator contractGenerator = new ServiceContractGenerator(codeCompileUnit, configuration)
			{
				Options = generationOptionsBuilder.Build(codeGeneratorOptions)
			};

			foreach (KeyValuePair<string, string> mapping in codeGeneratorOptions.NamespaceMappings)
			{
				contractGenerator.NamespaceMappings.Add(mapping.Key, mapping.Value);
			}

			return contractGenerator;
		}

		private static Configuration InitializeConfiguration()
		{
			Configuration machineConfiguration = ConfigurationManager.OpenMachineConfiguration();

			ExeConfigurationFileMap configurationFileMap = new ExeConfigurationFileMap
			{
				ExeConfigFilename = "EC0AF989-C6B4-43e7-BD11-25C9F48DF4BD.config",
				MachineConfigFilename = machineConfiguration.FilePath
			};
			Configuration configuration = ConfigurationManager.OpenMappedExeConfiguration(configurationFileMap, ConfigurationUserLevel.None);
			configuration.NamespaceDeclared = true;

			return configuration;
		}
	}
}