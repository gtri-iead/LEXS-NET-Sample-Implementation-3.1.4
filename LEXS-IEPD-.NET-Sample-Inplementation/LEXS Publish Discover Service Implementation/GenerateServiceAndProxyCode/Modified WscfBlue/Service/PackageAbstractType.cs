namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SearchResultPackageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataItemPackageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public abstract partial class PackageAbstractType : ComplexObjectType
    {
        
        private PackageMetadataType packageMetadataField;
        
        private DigestType digestField;
        
        private StructuredPayloadType[] structuredPayloadField;
        
        private AttachmentLinkType[] attachmentLinkField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PackageMetadataType PackageMetadata
        {
            get
            {
                return this.packageMetadataField;
            }
            set
            {
                this.packageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DigestType Digest
        {
            get
            {
                return this.digestField;
            }
            set
            {
                this.digestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayload", Order=2)]
        public StructuredPayloadType[] StructuredPayload
        {
            get
            {
                return this.structuredPayloadField;
            }
            set
            {
                this.structuredPayloadField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentLink", Order=3)]
        public AttachmentLinkType[] AttachmentLink
        {
            get
            {
                return this.attachmentLinkField;
            }
            set
            {
                this.attachmentLinkField = value;
            }
        }
    }
}
