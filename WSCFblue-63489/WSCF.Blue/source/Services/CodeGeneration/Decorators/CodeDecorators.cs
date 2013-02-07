using System.Collections.Generic;
using System.IO;
using Thinktecture.Tools.Web.Services.CodeGeneration.Decorators;
using System.ServiceModel.Description;

namespace Thinktecture.Tools.Web.Services.CodeGeneration
{
    /// <summary>
    /// This class abstracts several ICodeDecorators and provides the necessary
    /// interface to manipulate them.
    /// </summary>
    internal sealed class CodeDecorators
    {
        #region Private fields

        // THINK: May be we should fallback to ICodeDecorator[] instead of List<T> 
        // if List does not add too much value in this case ;).
        private List<ICodeDecorator> decorators;

        MetadataSet metadataSet = null;

        #endregion

        #region Constructors

        public CodeDecorators(MetadataSet metadataSet)
        {
            this.metadataSet = metadataSet;

            Initialize();
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Initializes the list of decorators.
        /// </summary>
        private void Initialize()
        {
            // Decorators are executed in the order they are 
            // added to the list here.
            decorators = new List<ICodeDecorator>();

            decorators.Add(new MissingTypesDecorator());

            decorators.Add(new PascalCaseConverter());
            decorators.Add(new ArraysToCollectionsConverter());
            decorators.Add(new ArraysToListsConverter());            
            decorators.Add(new ServiceTypeGenerator());
            decorators.Add(new ConfigurationDecorator());
            decorators.Add(new SvcFileGenerator());
        	decorators.Add(new ActionDecorator());

            decorators.Add(new SubstitutionGroupsDecorator());
        }

        #endregion

        
        #region Public methods

        /// <summary>
        /// Invokes all ICodeDecorator(s) in the decorators collection.
        /// </summary>
        public void ApplyDecorations(ExtendedCodeDomTree code, CustomCodeGenerationOptions options)
        {
            //string fileName = "C:\\Users\\rs239\\Documents\\NIEM\\temp\\Decorators.txt";
            //StringWriter stringWriter = new StringWriter();

            //stringWriter.WriteLine("Namespace = " + codeNamespace.Name);

            //stringWriter.WriteLine("___________________________________________");
            //stringWriter.WriteLine(ctd.Name);

            //FileStream fs = File.Open(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            //StreamWriter writer = new StreamWriter(fs);
            //writer.Write(stringWriter);
            //writer.Flush();
            
            foreach (ICodeDecorator decorator in decorators)
            {
                IMetadata metadataDecorator = decorator as IMetadata;
                if (metadataDecorator != null)
                {
                    metadataDecorator.MetadataSet = this.metadataSet;
                }

                decorator.Decorate(code, options);
            }
        }

        #endregion
    }
}