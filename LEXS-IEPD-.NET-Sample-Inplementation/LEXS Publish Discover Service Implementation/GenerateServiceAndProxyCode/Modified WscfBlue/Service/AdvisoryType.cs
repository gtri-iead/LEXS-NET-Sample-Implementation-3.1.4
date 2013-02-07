namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class AdvisoryType : ComplexObjectType
    {
        
        private AdvisoryCategoryCodeType advisoryCategoryField;
        
        private @string advisoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AdvisoryCategoryCodeType AdvisoryCategory
        {
            get
            {
                return this.advisoryCategoryField;
            }
            set
            {
                this.advisoryCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public @string AdvisoryText
        {
            get
            {
                return this.advisoryTextField;
            }
            set
            {
                this.advisoryTextField = value;
            }
        }
    }
}
