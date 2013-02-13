namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataOwnersResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilitiesResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AvailabilityResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachmentResponseMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class ResponseMessageType : SRMessageType
    {
        
        private ResponseMetadataType responseMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResponseMetadataType ResponseMetadata
        {
            get
            {
                return this.responseMetadataField;
            }
            set
            {
                this.responseMetadataField = value;
            }
        }
    }
}
