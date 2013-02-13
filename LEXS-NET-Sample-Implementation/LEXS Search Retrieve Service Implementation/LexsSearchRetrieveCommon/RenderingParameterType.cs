namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class RenderingParameterType : ComplexObjectType
    {
        
        private @string renderingParameterNameField;
        
        private @string renderingParameterValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string RenderingParameterName
        {
            get
            {
                return this.renderingParameterNameField;
            }
            set
            {
                this.renderingParameterNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public @string RenderingParameterValue
        {
            get
            {
                return this.renderingParameterValueField;
            }
            set
            {
                this.renderingParameterValueField = value;
            }
        }
    }
}
