namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="TelephoneNumberType", Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class TelephoneNumberType1 : TelephoneNumberType
    {
        
        private TelephoneNumberCategoryCodeType telephoneNumberCategoryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TelephoneNumberCategoryCodeType TelephoneNumberCategoryCode
        {
            get
            {
                return this.telephoneNumberCategoryCodeField;
            }
            set
            {
                this.telephoneNumberCategoryCodeField = value;
            }
        }
    }
}
