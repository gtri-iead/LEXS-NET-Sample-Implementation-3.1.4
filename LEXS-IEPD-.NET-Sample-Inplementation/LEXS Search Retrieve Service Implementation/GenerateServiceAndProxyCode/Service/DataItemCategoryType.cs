namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DataItemCategoryType : ComplexObjectType
    {
        
        private @string dataItemCategoryTextField;
        
        private @string dataItemCategoryDescriptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string DataItemCategoryText
        {
            get
            {
                return this.dataItemCategoryTextField;
            }
            set
            {
                this.dataItemCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public @string DataItemCategoryDescription
        {
            get
            {
                return this.dataItemCategoryDescriptionField;
            }
            set
            {
                this.dataItemCategoryDescriptionField = value;
            }
        }
    }
}
