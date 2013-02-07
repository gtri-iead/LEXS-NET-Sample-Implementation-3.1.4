using System.Collections.Generic;
using System.ServiceModel.Description;

using Moq;
using NUnit.Framework;
using Thinktecture.Wscf.Framework.Helpers;

namespace Thinktecture.Wscf.Framework.CodeGeneration
{
	[TestFixture]
	public class ServiceContractGeneratorBuilderTests
	{
		private readonly MetadataSet metadataSet = TestMetadata.MetadataSet;

		[Test]
		public void Build_CodeGeneratorContext_CodeCompileUnit()
		{
			ICodeGeneratorContext codeGeneratorContext = new CodeGeneratorContext(metadataSet, new CodeGeneratorOptions());
			ServiceContractGenerator contractGenerator = PerformBuild(codeGeneratorContext);

			Assert.That(contractGenerator.TargetCompileUnit, Is.EqualTo(codeGeneratorContext.CodeCompileUnit));
		}

		[Test]
		public void Build_Options_CreatedByOptionsBuilder()
		{
			ICodeGeneratorContext codeGeneratorContext = new CodeGeneratorContext(metadataSet, new CodeGeneratorOptions());
			const ServiceContractGenerationOptions serviceContractGenerationOptions = new ServiceContractGenerationOptions();

			Mock<IServiceContractGenerationOptionsBuilder> generationOptionsBuilder = new Mock<IServiceContractGenerationOptionsBuilder>();
			generationOptionsBuilder.Setup(mock => mock.Build(codeGeneratorContext.CodeGeneratorOptions)).Returns(serviceContractGenerationOptions);

			IServiceContractGeneratorBuilder builder = new ServiceContractGeneratorBuilder(generationOptionsBuilder.Object);
			ServiceContractGenerator contractGenerator = builder.Build(codeGeneratorContext);

			Assert.That(contractGenerator.Options, Is.EqualTo(serviceContractGenerationOptions));

			generationOptionsBuilder.Verify();
		}

		[Test]
		public void Build_Configuration_Initialized()
		{
			ServiceContractGenerator contractGenerator = PerformBuild(new CodeGeneratorOptions());

			Assert.That(contractGenerator.Configuration, Is.Not.Null);
			Assert.That(contractGenerator.Configuration.NamespaceDeclared, Is.True);
		}

		[Test]
		public void Build_CodeGeneratorOptions_NamespaceMappings()
		{
			const string expectedMappingKey1 = "1";
			const string expectedMappingKey2 = "2";
			const string expectedNamespace1 = "Namespace1";
			const string expectedNamespace2 = "Namespace2";

			Dictionary<string, string> mappings = new Dictionary<string, string>
			{
				{expectedMappingKey1, expectedNamespace1},
				{expectedMappingKey2, expectedNamespace2}
			};
			CodeGeneratorOptions options = new CodeGeneratorOptions {NamespaceMappings = mappings};
			ServiceContractGenerator contractGenerator = PerformBuild(options);
			IDictionary<string, string> namespaces = contractGenerator.NamespaceMappings;

			Assert.That(namespaces, Has.Count.EqualTo(2));
			Assert.That(namespaces[expectedMappingKey1], Is.EqualTo(expectedNamespace1));
			Assert.That(namespaces[expectedMappingKey2], Is.EqualTo(expectedNamespace2));
		}

		private ServiceContractGenerator PerformBuild(CodeGeneratorOptions codeGeneratorOptions)
		{
			return PerformBuild(new CodeGeneratorContext(metadataSet, codeGeneratorOptions));
		}

		private static ServiceContractGenerator PerformBuild(ICodeGeneratorContext codeGeneratorContext)
		{
			Mock<IServiceContractGenerationOptionsBuilder> generationOptionsBuilder = new Mock<IServiceContractGenerationOptionsBuilder>();
			IServiceContractGeneratorBuilder builder = new ServiceContractGeneratorBuilder(generationOptionsBuilder.Object);

			return builder.Build(codeGeneratorContext);
		}
	}
}