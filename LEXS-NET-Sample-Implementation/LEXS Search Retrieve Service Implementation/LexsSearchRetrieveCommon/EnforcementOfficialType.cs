namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class EnforcementOfficialType : ComplexObjectType
    {
        
        private ReferenceType roleOfPersonReferenceField;
        
        private IdentificationType enforcementOfficialBadgeIdentificationField;
        
        private TextType enforcementOfficialCategoryTextField;
        
        private EnforcementUnitType enforcementOfficialUnitField;
        
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
        public IdentificationType EnforcementOfficialBadgeIdentification
        {
            get
            {
                return this.enforcementOfficialBadgeIdentificationField;
            }
            set
            {
                this.enforcementOfficialBadgeIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType EnforcementOfficialCategoryText
        {
            get
            {
                return this.enforcementOfficialCategoryTextField;
            }
            set
            {
                this.enforcementOfficialCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public EnforcementUnitType EnforcementOfficialUnit
        {
            get
            {
                return this.enforcementOfficialUnitField;
            }
            set
            {
                this.enforcementOfficialUnitField = value;
            }
        }
    }
}
