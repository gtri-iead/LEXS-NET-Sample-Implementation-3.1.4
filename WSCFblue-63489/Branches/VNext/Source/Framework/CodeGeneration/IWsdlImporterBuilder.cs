using System.ServiceModel.Description;

namespace Thinktecture.Wscf.Framework.CodeGeneration
{
	/// <summary>
	/// A builder for creating <see cref="WsdlImporter"/> instances.
	/// </summary>
	public interface IWsdlImporterBuilder
	{
		/// <summary>
		/// Builds a new instance.
		/// </summary>
		/// <param name="codeGeneratorContext">The code generator context.</param>
		/// <returns>
		/// A new <see cref="WsdlImporter"/> instance.
		/// </returns>
		WsdlImporter Build(ICodeGeneratorContext codeGeneratorContext);
	}
}