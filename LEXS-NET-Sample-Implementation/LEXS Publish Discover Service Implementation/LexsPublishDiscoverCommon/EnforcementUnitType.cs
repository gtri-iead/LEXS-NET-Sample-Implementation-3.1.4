namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class EnforcementUnitType : OrganizationType
    {
        
        private IdentificationType enforcementUnitBeatIdentificationField;
        
        private IdentificationType enforcementUnitIdentificationField;
        
        private TextType enforcementUnitNameField;
        
        private IdentificationType enforcementUnitNumberIdentificationField;
        
        private IdentificationType enforcementUnitSectionIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType EnforcementUnitBeatIdentification
        {
            get
            {
                return this.enforcementUnitBeatIdentificationField;
            }
            set
            {
                this.enforcementUnitBeatIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public IdentificationType EnforcementUnitIdentification
        {
            get
            {
                return this.enforcementUnitIdentificationField;
            }
            set
            {
                this.enforcementUnitIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType EnforcementUnitName
        {
            get
            {
                return this.enforcementUnitNameField;
            }
            set
            {
                this.enforcementUnitNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public IdentificationType EnforcementUnitNumberIdentification
        {
            get
            {
                return this.enforcementUnitNumberIdentificationField;
            }
            set
            {
                this.enforcementUnitNumberIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public IdentificationType EnforcementUnitSectionIdentification
        {
            get
            {
                return this.enforcementUnitSectionIdentificationField;
            }
            set
            {
                this.enforcementUnitSectionIdentificationField = value;
            }
        }
    }
}
