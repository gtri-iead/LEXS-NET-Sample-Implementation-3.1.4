namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class PersonContactAssociationType : AssociationType
    {
        
        private ReferenceType personReferenceField;
        
        private ReferenceType contactPersonReferenceField;
        
        private PersonLanguageType contactPersonLanguageField;
        
        private ReferenceType[] contactPersonLocationReferenceField;
        
        private ReferenceType[] contactPersonEmailIDReferenceField;
        
        private ReferenceType[] contactPersonTelephoneNumberReferenceField;
        
        private TextType contactPersonRelationshipTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", Order=0)]
        public ReferenceType PersonReference
        {
            get
            {
                return this.personReferenceField;
            }
            set
            {
                this.personReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public ReferenceType ContactPersonReference
        {
            get
            {
                return this.contactPersonReferenceField;
            }
            set
            {
                this.contactPersonReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public PersonLanguageType ContactPersonLanguage
        {
            get
            {
                return this.contactPersonLanguageField;
            }
            set
            {
                this.contactPersonLanguageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPersonLocationReference", Order=3)]
        public ReferenceType[] ContactPersonLocationReference
        {
            get
            {
                return this.contactPersonLocationReferenceField;
            }
            set
            {
                this.contactPersonLocationReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPersonEmailIDReference", Order=4)]
        public ReferenceType[] ContactPersonEmailIDReference
        {
            get
            {
                return this.contactPersonEmailIDReferenceField;
            }
            set
            {
                this.contactPersonEmailIDReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactPersonTelephoneNumberReference", Order=5)]
        public ReferenceType[] ContactPersonTelephoneNumberReference
        {
            get
            {
                return this.contactPersonTelephoneNumberReferenceField;
            }
            set
            {
                this.contactPersonTelephoneNumberReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public TextType ContactPersonRelationshipText
        {
            get
            {
                return this.contactPersonRelationshipTextField;
            }
            set
            {
                this.contactPersonRelationshipTextField = value;
            }
        }
    }
}
