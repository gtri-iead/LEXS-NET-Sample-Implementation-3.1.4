﻿namespace Thinktecture.Tools.Web.Services.CodeGeneration.Decorators
{
	/// <summary>
	/// Generates .svc files for hosting in IIS and WAS.
	/// </summary>
    internal class SvcFileGenerator : ICodeDecorator
    {
        #region ICodeDecorator Members

		/// <summary>
		/// Decorates the specified code.
		/// </summary>
		/// <param name="code">The code.</param>
		/// <param name="options">The options.</param>
        public void Decorate(ExtendedCodeDomTree code, CustomCodeGenerationOptions options)
        {
            if (options.GenerateService && options.GenerateSvcFile)
            {
                foreach (CodeTypeExtension type in code.ServiceTypes)
                {
                    string fqTypeName = string.Format("{0}.{1}", options.ClrNamespace, type.ExtendedObject.Name);
                    string content = string.Format("<%@ ServiceHost Service=\"{0}\" %>", fqTypeName);
                    string filename = string.Format("{0}.svc", type.ExtendedObject.Name);
                    TextFile svcFile = new TextFile(filename, content);
                    code.TextFiles.Add(svcFile);
                }
            }
        }

        #endregion
    }
}
