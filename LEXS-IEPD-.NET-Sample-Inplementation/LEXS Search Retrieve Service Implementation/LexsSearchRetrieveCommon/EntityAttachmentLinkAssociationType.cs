namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityAttachmentLinkAssociationType : AssociationType
    {
        
        private ReferenceType entityReferenceField;
        
        private ReferenceType attachmentLinkReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType EntityReference
        {
            get
            {
                return this.entityReferenceField;
            }
            set
            {
                this.entityReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType AttachmentLinkReference
        {
            get
            {
                return this.attachmentLinkReferenceField;
            }
            set
            {
                this.attachmentLinkReferenceField = value;
            }
        }
    }
}
