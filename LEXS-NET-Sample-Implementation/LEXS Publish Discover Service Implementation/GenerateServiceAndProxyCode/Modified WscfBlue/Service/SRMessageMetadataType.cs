namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class SRMessageMetadataType : MessageMetadataAbstractType
    {
        
        private SystemMetadataType messageOriginMetadataField;
        
        private SystemIdentifierType[] messageDestinationIdentifierField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SystemMetadataType MessageOriginMetadata
        {
            get
            {
                return this.messageOriginMetadataField;
            }
            set
            {
                this.messageOriginMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageDestinationIdentifier", Order=1)]
        public SystemIdentifierType[] MessageDestinationIdentifier
        {
            get
            {
                return this.messageDestinationIdentifierField;
            }
            set
            {
                this.messageDestinationIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=2)]
        public DomainAttributeType[] DomainAttribute
        {
            get
            {
                return this.domainAttributeField;
            }
            set
            {
                this.domainAttributeField = value;
            }
        }
    }
}
