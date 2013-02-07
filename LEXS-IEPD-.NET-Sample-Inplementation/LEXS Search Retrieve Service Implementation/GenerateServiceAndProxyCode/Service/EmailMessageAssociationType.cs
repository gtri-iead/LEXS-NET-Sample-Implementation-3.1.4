namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EmailMessageAssociationType : AssociationType
    {
        
        private ReferenceType originatorPersonReferenceField;
        
        private ReferenceType originatorOrganizationReferenceField;
        
        private ReferenceType originatorEmailIDReferenceField;
        
        private ReferenceType[] receiverPersonReferenceField;
        
        private ReferenceType[] receiverOrganizationReferenceField;
        
        private ReferenceType receiverEmailIDReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ReferenceType OriginatorPersonReference
        {
            get
            {
                return this.originatorPersonReferenceField;
            }
            set
            {
                this.originatorPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType OriginatorOrganizationReference
        {
            get
            {
                return this.originatorOrganizationReferenceField;
            }
            set
            {
                this.originatorOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ReferenceType OriginatorEmailIDReference
        {
            get
            {
                return this.originatorEmailIDReferenceField;
            }
            set
            {
                this.originatorEmailIDReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiverPersonReference", Order=3)]
        public ReferenceType[] ReceiverPersonReference
        {
            get
            {
                return this.receiverPersonReferenceField;
            }
            set
            {
                this.receiverPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiverOrganizationReference", Order=4)]
        public ReferenceType[] ReceiverOrganizationReference
        {
            get
            {
                return this.receiverOrganizationReferenceField;
            }
            set
            {
                this.receiverOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ReferenceType ReceiverEmailIDReference
        {
            get
            {
                return this.receiverEmailIDReferenceField;
            }
            set
            {
                this.receiverEmailIDReferenceField = value;
            }
        }
    }
}
