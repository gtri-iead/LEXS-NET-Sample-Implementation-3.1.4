namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class CriminalOrganizationType : ComplexObjectType
    {
        
        private ReferenceType roleOfOrganizationReferenceField;
        
        private TextType criminalOrganizationCautionTextField;
        
        private IdentificationType criminalOrganizationNCICIdentificationField;
        
        private TextType criminalOrganizationObjectiveTextField;
        
        private CriminalTraitDetailsType criminalOrganizationTraitDetailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType RoleOfOrganizationReference
        {
            get
            {
                return this.roleOfOrganizationReferenceField;
            }
            set
            {
                this.roleOfOrganizationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType CriminalOrganizationCautionText
        {
            get
            {
                return this.criminalOrganizationCautionTextField;
            }
            set
            {
                this.criminalOrganizationCautionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public IdentificationType CriminalOrganizationNCICIdentification
        {
            get
            {
                return this.criminalOrganizationNCICIdentificationField;
            }
            set
            {
                this.criminalOrganizationNCICIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType CriminalOrganizationObjectiveText
        {
            get
            {
                return this.criminalOrganizationObjectiveTextField;
            }
            set
            {
                this.criminalOrganizationObjectiveTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public CriminalTraitDetailsType CriminalOrganizationTraitDetails
        {
            get
            {
                return this.criminalOrganizationTraitDetailsField;
            }
            set
            {
                this.criminalOrganizationTraitDetailsField = value;
            }
        }
    }
}
