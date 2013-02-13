namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class JudicialOfficialType : ComplexObjectType
    {
        
        private ReferenceType roleOfPersonReferenceField;
        
        private OrganizationType judicialOfficialFirmField;
        
        private IdentificationType judicialOfficialPanelIdentificationField;
        
        private IdentificationType judicialOfficialRegistrationIdentificationField;
        
        private TextType judicialOfficialCategoryTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType RoleOfPersonReference
        {
            get
            {
                return this.roleOfPersonReferenceField;
            }
            set
            {
                this.roleOfPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public OrganizationType JudicialOfficialFirm
        {
            get
            {
                return this.judicialOfficialFirmField;
            }
            set
            {
                this.judicialOfficialFirmField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public IdentificationType JudicialOfficialPanelIdentification
        {
            get
            {
                return this.judicialOfficialPanelIdentificationField;
            }
            set
            {
                this.judicialOfficialPanelIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public IdentificationType JudicialOfficialRegistrationIdentification
        {
            get
            {
                return this.judicialOfficialRegistrationIdentificationField;
            }
            set
            {
                this.judicialOfficialRegistrationIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType JudicialOfficialCategoryText
        {
            get
            {
                return this.judicialOfficialCategoryTextField;
            }
            set
            {
                this.judicialOfficialCategoryTextField = value;
            }
        }
    }
}
