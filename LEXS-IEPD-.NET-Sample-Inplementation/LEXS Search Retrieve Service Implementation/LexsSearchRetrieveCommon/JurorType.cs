namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/jxdm/4.0")]
    public partial class JurorType : ComplexObjectType
    {
        
        private ReferenceType roleOfPersonReferenceField;
        
        private DateType jurorDismissedDateField;
        
        private boolean jurorDismissedIndicatorField;
        
        private TextType jurorDismissedReasonTextField;
        
        private boolean jurorForemanIndicatorField;
        
        private IdentificationType jurorIdentificationField;
        
        private IdentificationType jurorPanelIdentificationField;
        
        private boolean jurorPrimaryIndicatorField;
        
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
        public DateType JurorDismissedDate
        {
            get
            {
                return this.jurorDismissedDateField;
            }
            set
            {
                this.jurorDismissedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public boolean JurorDismissedIndicator
        {
            get
            {
                return this.jurorDismissedIndicatorField;
            }
            set
            {
                this.jurorDismissedIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType JurorDismissedReasonText
        {
            get
            {
                return this.jurorDismissedReasonTextField;
            }
            set
            {
                this.jurorDismissedReasonTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public boolean JurorForemanIndicator
        {
            get
            {
                return this.jurorForemanIndicatorField;
            }
            set
            {
                this.jurorForemanIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public IdentificationType JurorIdentification
        {
            get
            {
                return this.jurorIdentificationField;
            }
            set
            {
                this.jurorIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public IdentificationType JurorPanelIdentification
        {
            get
            {
                return this.jurorPanelIdentificationField;
            }
            set
            {
                this.jurorPanelIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public boolean JurorPrimaryIndicator
        {
            get
            {
                return this.jurorPrimaryIndicatorField;
            }
            set
            {
                this.jurorPrimaryIndicatorField = value;
            }
        }
    }
}
