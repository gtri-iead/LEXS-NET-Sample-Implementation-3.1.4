namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class TelephoneCallAssociationType : AssociationType
    {
        
        private ReferenceType originatorPersonReferenceField;
        
        private ReferenceType originatorOrganizationReferenceField;
        
        private ReferenceType originatorTelephoneNumberReferenceField;
        
        private ReferenceType[] receiverPersonReferenceField;
        
        private ReferenceType[] receiverOrganizationReferenceField;
        
        private ReferenceType[] receiverTelephoneNumberReferenceField;
        
        private duration callDurationField;
        
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
        public ReferenceType OriginatorTelephoneNumberReference
        {
            get
            {
                return this.originatorTelephoneNumberReferenceField;
            }
            set
            {
                this.originatorTelephoneNumberReferenceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ReceiverTelephoneNumberReference", Order=5)]
        public ReferenceType[] ReceiverTelephoneNumberReference
        {
            get
            {
                return this.receiverTelephoneNumberReferenceField;
            }
            set
            {
                this.receiverTelephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public duration CallDuration
        {
            get
            {
                return this.callDurationField;
            }
            set
            {
                this.callDurationField = value;
            }
        }
    }
}
