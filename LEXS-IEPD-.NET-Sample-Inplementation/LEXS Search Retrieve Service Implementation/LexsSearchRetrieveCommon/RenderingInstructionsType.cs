namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class RenderingInstructionsType : ComplexObjectType
    {
        
        private RenderingMethodCodeType renderingMethodField;
        
        private ReferenceType renderingReferenceField;
        
        private RenderingParameterType[] renderingParameterField;
        
        private @string renderingDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public RenderingMethodCodeType RenderingMethod
        {
            get
            {
                return this.renderingMethodField;
            }
            set
            {
                this.renderingMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType RenderingReference
        {
            get
            {
                return this.renderingReferenceField;
            }
            set
            {
                this.renderingReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RenderingParameter", Order=2)]
        public RenderingParameterType[] RenderingParameter
        {
            get
            {
                return this.renderingParameterField;
            }
            set
            {
                this.renderingParameterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public @string RenderingDescription
        {
            get
            {
                return this.renderingDescriptionField;
            }
            set
            {
                this.renderingDescriptionField = value;
            }
        }
    }
}
