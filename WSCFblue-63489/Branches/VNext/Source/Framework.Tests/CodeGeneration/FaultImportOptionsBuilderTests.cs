using System.ServiceModel;

using NUnit.Framework;

namespace Thinktecture.Wscf.Framework.CodeGeneration
{
	[TestFixture]
	public class FaultImportOptionsBuilderTests
	{
		[Test]
		public void BuildFaultImportOptions_UseMessageFormat_IsTrue()
		{
			IFaultImportOptionsBuilder builder = new FaultImportOptionsBuilder();
			FaultImportOptions faultImportOptions = builder.Build();

			Assert.That(faultImportOptions.UseMessageFormat, Is.True);
		}
	}
}