namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/searchretrieve/3.1")]
    public partial class getDataItemResponseType
    {
        
        private DataItemResponseMessageType dataItemResponseMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1", Order=0)]
        public DataItemResponseMessageType DataItemResponseMessage
        {
            get
            {
                return this.dataItemResponseMessageField;
            }
            set
            {
                this.dataItemResponseMessageField = value;
            }
        }
    }
}
