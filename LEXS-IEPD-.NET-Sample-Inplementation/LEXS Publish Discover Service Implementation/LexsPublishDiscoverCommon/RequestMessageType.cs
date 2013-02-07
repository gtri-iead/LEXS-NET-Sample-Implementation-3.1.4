namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachmentRequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class RequestMessageType : SRMessageType
    {
        
        private UserAssertionType userAssertionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public UserAssertionType UserAssertion
        {
            get
            {
                return this.userAssertionField;
            }
            set
            {
                this.userAssertionField = value;
            }
        }
    }
}
