namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class WitnessType : ComplexObjectType
    {
        
        private ReferenceType roleOfPersonReferenceField;
        
        private IdentificationType witnessIdentificationField;
        
        private TextType witnessAccountDescriptionTextField;
        
        private DateType witnessDateField;
        
        private TextType witnessLocationDescriptionTextField;
        
        private boolean witnessReportVerifiedIndicatorField;
        
        private TextType witnessSpecialConditionTextField;
        
        private boolean witnessWillTestifyIndicatorField;
        
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
        public IdentificationType WitnessIdentification
        {
            get
            {
                return this.witnessIdentificationField;
            }
            set
            {
                this.witnessIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType WitnessAccountDescriptionText
        {
            get
            {
                return this.witnessAccountDescriptionTextField;
            }
            set
            {
                this.witnessAccountDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public DateType WitnessDate
        {
            get
            {
                return this.witnessDateField;
            }
            set
            {
                this.witnessDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType WitnessLocationDescriptionText
        {
            get
            {
                return this.witnessLocationDescriptionTextField;
            }
            set
            {
                this.witnessLocationDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public boolean WitnessReportVerifiedIndicator
        {
            get
            {
                return this.witnessReportVerifiedIndicatorField;
            }
            set
            {
                this.witnessReportVerifiedIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType WitnessSpecialConditionText
        {
            get
            {
                return this.witnessSpecialConditionTextField;
            }
            set
            {
                this.witnessSpecialConditionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public boolean WitnessWillTestifyIndicator
        {
            get
            {
                return this.witnessWillTestifyIndicatorField;
            }
            set
            {
                this.witnessWillTestifyIndicatorField = value;
            }
        }
    }
}
