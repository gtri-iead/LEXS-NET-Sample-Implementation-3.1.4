namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class ServiceAssociationType : AssociationType
    {
        
        private ReferenceType[] serviceProviderPersonReferenceField;
        
        private ReferenceType[] serviceProviderOrganizationReferenceField;
        
        private ReferenceType[] serviceRecipientPersonReferenceField;
        
        private ReferenceType[] serviceRecipientOrganizationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderPersonReference", Order=0)]
        public ReferenceType[] ServiceProviderPersonReference
        {
            get
            {
                return this.serviceProviderPersonReferenceField;
            }
            set
            {
                this.serviceProviderPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceProviderOrganizationReference", Order=1)]
        public ReferenceType[] ServiceProviderOrganizationReference
        {
            get
            {
                return this.serviceProviderOrganizationReferenceField;
            }
            set
            {
                this.serviceProviderOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipientPersonReference", Order=2)]
        public ReferenceType[] ServiceRecipientPersonReference
        {
            get
            {
                return this.serviceRecipientPersonReferenceField;
            }
            set
            {
                this.serviceRecipientPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceRecipientOrganizationReference", Order=3)]
        public ReferenceType[] ServiceRecipientOrganizationReference
        {
            get
            {
                return this.serviceRecipientOrganizationReferenceField;
            }
            set
            {
                this.serviceRecipientOrganizationReferenceField = value;
            }
        }
    }
}
