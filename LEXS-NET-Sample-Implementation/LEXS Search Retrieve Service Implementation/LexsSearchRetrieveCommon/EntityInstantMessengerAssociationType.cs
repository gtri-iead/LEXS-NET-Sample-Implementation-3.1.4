namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class EntityInstantMessengerAssociationType : AssociationType
    {
        
        private ReferenceType[] organizationReferenceField;
        
        private ReferenceType[] personReferenceField;
        
        private ReferenceType[] instantMessengerReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType[] OrganizationReference
        {
            get
            {
                return this.organizationReferenceField;
            }
            set
            {
                this.organizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonReference", Namespace="http://niem.gov/niem/niem-core/2.0", Order=1)]
        public ReferenceType[] PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InstantMessengerReference", Order=2)]
        public ReferenceType[] InstantMessengerReference
        {
            get
            {
                return this.instantMessengerReferenceField;
            }
            set
            {
                this.instantMessengerReferenceField = value;
            }
        }
    }
}
