namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class PublishMessageType
    {
        
        private PDMessageMetadataType pDMessageMetadataField;
        
        private SystemMetadataType dataSubmitterMetadataField;
        
        private ComplexObjectType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PDMessageMetadataType PDMessageMetadata
        {
            get
            {
                return this.pDMessageMetadataField;
            }
            set
            {
                this.pDMessageMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SystemMetadataType DataSubmitterMetadata
        {
            get
            {
                return this.dataSubmitterMetadataField;
            }
            set
            {
                this.dataSubmitterMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment", typeof(AttachmentType), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("DataItemPackage", typeof(DataItemPackageType), Order=2)]
        public ComplexObjectType[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }
}
