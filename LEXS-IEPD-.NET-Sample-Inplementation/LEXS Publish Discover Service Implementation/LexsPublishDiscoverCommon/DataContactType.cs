namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DataContactType : ComplexObjectType
    {
        
        private PersonNameTextType personGivenNameField;
        
        private PersonNameTextType personMiddleNameField;
        
        private PersonNameTextType personSurNameField;
        
        private PersonNameTextType personFullNameField;
        
        private object[] itemsField;
        
        private TextType organizationNameField;
        
        private DomainAttributeType[] domainAttributeField;

        // Test
        private TelephoneNumberType[] items2Field;
        private ItemsChoiceType10[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=0)]
        public PersonNameTextType PersonGivenName
        {
            get
            {
                return this.personGivenNameField;
            }
            set
            {
                this.personGivenNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=1)]
        public PersonNameTextType PersonMiddleName
        {
            get
            {
                return this.personMiddleNameField;
            }
            set
            {
                this.personMiddleNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=2)]
        public PersonNameTextType PersonSurName
        {
            get
            {
                return this.personSurNameField;
            }
            set
            {
                this.personSurNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=3)]
        public PersonNameTextType PersonFullName
        {
            get
            {
                return this.personFullNameField;
            }
            set
            {
                this.personFullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactEmailID", typeof(@string), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("ContactInstantMessenger", typeof(InstantMessengerType), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        [System.Xml.Serialization.XmlElementAttribute("ContactTelephoneNumber", typeof(TelephoneNumberType), Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=4)]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        // Test
        [System.Xml.Serialization.XmlElementAttribute("ContactFaxNumber", typeof(TelephoneNumberType), Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("ContactMobileTelephoneNumber", typeof(TelephoneNumberType), Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 5)]
        [System.Xml.Serialization.XmlElementAttribute("ContactPagerNumber", typeof(TelephoneNumberType), Namespace = "http://niem.gov/niem/niem-core/2.0", IsNullable = true, Order = 5)]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public TelephoneNumberType[] Items2
        {
            get
            {
                return this.items2Field;
            }
            set
            {
                this.items2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order = 6)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType10[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace="http://niem.gov/niem/niem-core/2.0", IsNullable=true, Order=7)]
        public TextType OrganizationName
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
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=8)]
        public DomainAttributeType[] DomainAttribute
        {
            get
            {
                return this.domainAttributeField;
            }
            set
            {
                this.domainAttributeField = value;
            }
        }


        /// <remarks/>
        [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://niem.gov/niem/niem-core/2.0", IncludeInSchema = false)]
        public enum ItemsChoiceType10
        {

            /// <remarks/>
            ContactFaxNumber,

            /// <remarks/>
            ContactMobileTelephoneNumber,

            /// <remarks/>
            ContactPagerNumber,
        }
    }
}
