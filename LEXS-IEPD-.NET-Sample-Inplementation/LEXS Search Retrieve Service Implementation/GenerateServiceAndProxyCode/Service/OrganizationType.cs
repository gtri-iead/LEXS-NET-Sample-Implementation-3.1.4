namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EnforcementUnitType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class OrganizationType : ComplexObjectType
    {
        
        private TextType itemField;
        
        private TextType[] organizationNameField;
        
        private IdentificationType organizationTaxIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationCategoryText", IsNullable=true, Order=0)]
        public TextType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrganizationName", IsNullable=true, Order=1)]
        public TextType[] OrganizationName
        {
            get
            {
                return this.organizationNameField;
            }
            set
            {
                this.organizationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public IdentificationType OrganizationTaxIdentification
        {
            get
            {
                return this.organizationTaxIdentificationField;
            }
            set
            {
                this.organizationTaxIdentificationField = value;
            }
        }
    }
}
