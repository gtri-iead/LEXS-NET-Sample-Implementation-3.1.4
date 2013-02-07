namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="PersonAugmentationType", Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class PersonAugmentationType1 : AugmentationType
    {
        
        private IdentificationType[] alienNumberField;
        
        private PersonRegisterNumberType[] personRegisterNumberField;
        
        private IdentificationType[] personUSMSFugitiveIdentificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlienNumber", Namespace="http://niem.gov/niem/domains/immigration/2.0", IsNullable=true, Order=0)]
        public IdentificationType[] AlienNumber
        {
            get
            {
                return this.alienNumberField;
            }
            set
            {
                this.alienNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonRegisterNumber", IsNullable=true, Order=1)]
        public PersonRegisterNumberType[] PersonRegisterNumber
        {
            get
            {
                return this.personRegisterNumberField;
            }
            set
            {
                this.personRegisterNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonUSMSFugitiveIdentification", IsNullable=true, Order=2)]
        public IdentificationType[] PersonUSMSFugitiveIdentification
        {
            get
            {
                return this.personUSMSFugitiveIdentificationField;
            }
            set
            {
                this.personUSMSFugitiveIdentificationField = value;
            }
        }
    }
}
