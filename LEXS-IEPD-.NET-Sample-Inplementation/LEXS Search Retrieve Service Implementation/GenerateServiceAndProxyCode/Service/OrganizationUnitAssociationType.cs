namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class OrganizationUnitAssociationType : AssociationType
    {
        
        private ReferenceType[] organizationReferenceField;
        
        private ReferenceType[] organizationUnitReferenceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationReference", Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute("OrganizationUnitReference", Order=1)]
        public ReferenceType[] OrganizationUnitReference
        {
            get
            {
                return this.organizationUnitReferenceField;
            }
            set
            {
                this.organizationUnitReferenceField = value;
            }
        }
    }
}
