using System.ServiceModel.Description;

namespace Thinktecture.Wscf.Framework.CodeGeneration
{
	/// <summary>
	/// A builder for creating <see cref="ServiceContractGenerator"/> instances.
	/// </summary>
	public interface IServiceContractGeneratorBuilder
	{
		/// <summary>
		/// Builds a new instance.
		/// </summary>
		/// <param name="codeGeneratorContext">The code generator context.</param>
		/// <returns>
		/// A new <see cref="ServiceContractGenerator"/> instance.
		/// </returns>
		ServiceContractGenerator Build(ICodeGeneratorContext codeGeneratorContext);
	}
}