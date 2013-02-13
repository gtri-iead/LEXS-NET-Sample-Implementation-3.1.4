namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class AttachmentRequestMessageType : RequestMessageType
    {
        
        private AnyURIType[] attachmentURIField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentURI", Order=0)]
        public AnyURIType[] AttachmentURI
        {
            get
            {
                return this.attachmentURIField;
            }
            set
            {
                this.attachmentURIField = value;
            }
        }
    }
}
