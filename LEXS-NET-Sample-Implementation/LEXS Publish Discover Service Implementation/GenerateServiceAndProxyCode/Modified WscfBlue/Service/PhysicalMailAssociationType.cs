namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class PhysicalMailAssociationType : AssociationType
    {
        
        private ReferenceType recipientPersonReferenceField;
        
        private ReferenceType recipientOrganizationReferenceField;
        
        private ReferenceType recipientLocationReferenceField;
        
        private ReferenceType senderPersonReferenceField;
        
        private ReferenceType senderOrganizationReferenceField;
        
        private ReferenceType senderLocationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType RecipientPersonReference
        {
            get
            {
                return this.recipientPersonReferenceField;
            }
            set
            {
                this.recipientPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType RecipientOrganizationReference
        {
            get
            {
                return this.recipientOrganizationReferenceField;
            }
            set
            {
                this.recipientOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ReferenceType RecipientLocationReference
        {
            get
            {
                return this.recipientLocationReferenceField;
            }
            set
            {
                this.recipientLocationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ReferenceType SenderPersonReference
        {
            get
            {
                return this.senderPersonReferenceField;
            }
            set
            {
                this.senderPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public ReferenceType SenderOrganizationReference
        {
            get
            {
                return this.senderOrganizationReferenceField;
            }
            set
            {
                this.senderOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ReferenceType SenderLocationReference
        {
            get
            {
                return this.senderLocationReferenceField;
            }
            set
            {
                this.senderLocationReferenceField = value;
            }
        }
    }
}
