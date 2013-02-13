namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class BailBondAssociationType : AssociationType
    {
        
        private ReferenceType[] bailingPersonReferenceField;
        
        private ReferenceType[] bailingOrganizationReferenceField;
        
        private ReferenceType baileePersonReferenceField;
        
        private ReferenceType bailBondsmanPersonReferenceField;
        
        private ReferenceType bailBondsmanOrganizationReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BailingPersonReference", Order=0)]
        public ReferenceType[] BailingPersonReference
        {
            get
            {
                return this.bailingPersonReferenceField;
            }
            set
            {
                this.bailingPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BailingOrganizationReference", Order=1)]
        public ReferenceType[] BailingOrganizationReference
        {
            get
            {
                return this.bailingOrganizationReferenceField;
            }
            set
            {
                this.bailingOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ReferenceType BaileePersonReference
        {
            get
            {
                return this.baileePersonReferenceField;
            }
            set
            {
                this.baileePersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public ReferenceType BailBondsmanPersonReference
        {
            get
            {
                return this.bailBondsmanPersonReferenceField;
            }
            set
            {
                this.bailBondsmanPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public ReferenceType BailBondsmanOrganizationReference
        {
            get
            {
                return this.bailBondsmanOrganizationReferenceField;
            }
            set
            {
                this.bailBondsmanOrganizationReferenceField = value;
            }
        }
    }
}
