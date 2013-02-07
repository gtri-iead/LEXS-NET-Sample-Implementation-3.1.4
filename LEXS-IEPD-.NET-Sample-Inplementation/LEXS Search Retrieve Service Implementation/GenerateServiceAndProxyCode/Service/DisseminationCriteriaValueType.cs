namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DisseminationCriteriaValueType : ComplexObjectType
    {
        
        private @string disseminationCriteriaDomainTextField;
        
        private @string disseminationCriteriaTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string DisseminationCriteriaDomainText
        {
            get
            {
                return this.disseminationCriteriaDomainTextField;
            }
            set
            {
                this.disseminationCriteriaDomainTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public @string DisseminationCriteriaText
        {
            get
            {
                return this.disseminationCriteriaTextField;
            }
            set
            {
                this.disseminationCriteriaTextField = value;
            }
        }
    }
}
