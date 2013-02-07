namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class CreditCardType : ItemType
    {
        
        private TextType itemField;
        
        private DateType creditCardExpirationDateField;
        
        private TextType creditCardIssuerOrganizationNameField;
        
        private TextType creditCardNumberField;
        
        private TextType creditCardOwnerNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreditCardCategoryText", IsNullable=true, Order=0)]
        public TextType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public DateType CreditCardExpirationDate
        {
            get
            {
                return this.creditCardExpirationDateField;
            }
            set
            {
                this.creditCardExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType CreditCardIssuerOrganizationName
        {
            get
            {
                return this.creditCardIssuerOrganizationNameField;
            }
            set
            {
                this.creditCardIssuerOrganizationNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public TextType CreditCardNumber
        {
            get
            {
                return this.creditCardNumberField;
            }
            set
            {
                this.creditCardNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public TextType CreditCardOwnerName
        {
            get
            {
                return this.creditCardOwnerNameField;
            }
            set
            {
                this.creditCardOwnerNameField = value;
            }
        }
    }
}
