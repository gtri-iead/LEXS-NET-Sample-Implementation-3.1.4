namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DomainResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataOwnersResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CapabilitiesResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AvailabilityResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttachmentResponseMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestMessageType))]
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
    public partial class SRMessageType
    {
        
        private SRMessageMetadataType sRMessageMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SRMessageMetadataType SRMessageMetadata
        {
            get
            {
                return this.sRMessageMetadataField;
            }
            set
            {
                this.sRMessageMetadataField = value;
            }
        }
    }
}
