namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class DocumentType : ComplexObjectType
    {
        
        private DateType documentCreationDateField;
        
        private TextType documentDescriptionTextField;
        
        private @string documentFileControlIDField;
        
        private IdentificationType documentIdentificationField;
        
        private TextType documentKeywordTextField;
        
        private TextType documentTitleTextField;
        
        private TextType securityLevelTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public DateType DocumentCreationDate
        {
            get
            {
                return this.documentCreationDateField;
            }
            set
            {
                this.documentCreationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType DocumentDescriptionText
        {
            get
            {
                return this.documentDescriptionTextField;
            }
            set
            {
                this.documentDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public @string DocumentFileControlID
        {
            get
            {
                return this.documentFileControlIDField;
            }
            set
            {
                this.documentFileControlIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public IdentificationType DocumentIdentification
        {
            get
            {
                return this.documentIdentificationField;
            }
            set
            {
                this.documentIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType DocumentKeywordText
        {
            get
            {
                return this.documentKeywordTextField;
            }
            set
            {
                this.documentKeywordTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public TextType DocumentTitleText
        {
            get
            {
                return this.documentTitleTextField;
            }
            set
            {
                this.documentTitleTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType SecurityLevelText
        {
            get
            {
                return this.securityLevelTextField;
            }
            set
            {
                this.securityLevelTextField = value;
            }
        }
    }
}
