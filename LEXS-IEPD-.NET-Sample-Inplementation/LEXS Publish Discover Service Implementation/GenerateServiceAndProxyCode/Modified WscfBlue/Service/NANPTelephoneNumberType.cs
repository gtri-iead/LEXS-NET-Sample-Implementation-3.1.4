namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class NANPTelephoneNumberType : ComplexObjectType
    {
        
        private @string telephoneAreaCodeIDField;
        
        private @string telephoneExchangeIDField;
        
        private @string telephoneLineIDField;
        
        private @string telephoneSuffixIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public @string TelephoneAreaCodeID
        {
            get
            {
                return this.telephoneAreaCodeIDField;
            }
            set
            {
                this.telephoneAreaCodeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public @string TelephoneExchangeID
        {
            get
            {
                return this.telephoneExchangeIDField;
            }
            set
            {
                this.telephoneExchangeIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public @string TelephoneLineID
        {
            get
            {
                return this.telephoneLineIDField;
            }
            set
            {
                this.telephoneLineIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public @string TelephoneSuffixID
        {
            get
            {
                return this.telephoneSuffixIDField;
            }
            set
            {
                this.telephoneSuffixIDField = value;
            }
        }
    }
}
