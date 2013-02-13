namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class NetworkAddressAssociationType : AssociationType
    {
        
        private ReferenceType originatorNetworkAddressReferenceField;
        
        private ReferenceType originatorOrganizationReferenceField;
        
        private ReferenceType originatorPersonReferenceField;
        
        private ReferenceType receiverNetworkAddressReferenceField;
        
        private ReferenceType receiverOrganizationReferenceField;
        
        private ReferenceType receiverPersonReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public ReferenceType OriginatorNetworkAddressReference
        {
            get
            {
                return this.originatorNetworkAddressReferenceField;
            }
            set
            {
                this.originatorNetworkAddressReferenceField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public ReferenceType ReceiverNetworkAddressReference
        {
            get
            {
                return this.receiverNetworkAddressReferenceField;
            }
            set
            {
                this.receiverNetworkAddressReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public ReferenceType ReceiverOrganizationReference
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
        public ReferenceType ReceiverPersonReference
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
    }
}
