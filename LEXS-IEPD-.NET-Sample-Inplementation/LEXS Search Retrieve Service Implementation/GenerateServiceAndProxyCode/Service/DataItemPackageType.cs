namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DataItemPackageType : PackageAbstractType
    {
        
        private RenderingInstructionsType[] renderingInstructionsField;
        
        private @string narrativeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RenderingInstructions", Order=0)]
        public RenderingInstructionsType[] RenderingInstructions
        {
            get
            {
                return this.renderingInstructionsField;
            }
            set
            {
                this.renderingInstructionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public @string Narrative
        {
            get
            {
                return this.narrativeField;
            }
            set
            {
                this.narrativeField = value;
            }
        }
    }
}
