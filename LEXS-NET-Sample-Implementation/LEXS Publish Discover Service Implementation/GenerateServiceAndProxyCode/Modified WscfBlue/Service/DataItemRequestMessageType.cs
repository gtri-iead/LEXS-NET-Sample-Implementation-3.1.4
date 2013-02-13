namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DataItemRequestMessageType : RequestMessageType
    {
        
        private @string dataItemIDField;
        
        private object itemField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string DataItemID
        {
            get
            {
                return this.dataItemIDField;
            }
            set
            {
                this.dataItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedCode", typeof(StructuredPayloadsRequestedCodeType), Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedList", typeof(StructuredPayloadsRequestedListType), Order=1)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
}
