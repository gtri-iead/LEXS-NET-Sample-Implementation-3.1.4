namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class RegisteredOffenderType : ComplexObjectType
    {
        
        private ReferenceType roleOfPersonReferenceField;
        
        private TextType registeredOffenderDescriptionField;
        
        private DateType registeredOffenderEndDateField;
        
        private DateType registeredOffenderEntryDateField;
        
        private IdentificationType registeredOffenderIdentificationField;
        
        private TextType registeredOffenderReportingCriteriaTextField;
        
        private TextType registeredOffenderReportingProfessionNameField;
        
        private DateType registeredOffenderStartDateField;
        
        private TextType registeredOffenderCategoryTextField;
        
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
        public TextType RegisteredOffenderDescription
        {
            get
            {
                return this.registeredOffenderDescriptionField;
            }
            set
            {
                this.registeredOffenderDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public DateType RegisteredOffenderEndDate
        {
            get
            {
                return this.registeredOffenderEndDateField;
            }
            set
            {
                this.registeredOffenderEndDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public DateType RegisteredOffenderEntryDate
        {
            get
            {
                return this.registeredOffenderEntryDateField;
            }
            set
            {
                this.registeredOffenderEntryDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public IdentificationType RegisteredOffenderIdentification
        {
            get
            {
                return this.registeredOffenderIdentificationField;
            }
            set
            {
                this.registeredOffenderIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType RegisteredOffenderReportingCriteriaText
        {
            get
            {
                return this.registeredOffenderReportingCriteriaTextField;
            }
            set
            {
                this.registeredOffenderReportingCriteriaTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType RegisteredOffenderReportingProfessionName
        {
            get
            {
                return this.registeredOffenderReportingProfessionNameField;
            }
            set
            {
                this.registeredOffenderReportingProfessionNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public DateType RegisteredOffenderStartDate
        {
            get
            {
                return this.registeredOffenderStartDateField;
            }
            set
            {
                this.registeredOffenderStartDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public TextType RegisteredOffenderCategoryText
        {
            get
            {
                return this.registeredOffenderCategoryTextField;
            }
            set
            {
                this.registeredOffenderCategoryTextField = value;
            }
        }
    }
}
