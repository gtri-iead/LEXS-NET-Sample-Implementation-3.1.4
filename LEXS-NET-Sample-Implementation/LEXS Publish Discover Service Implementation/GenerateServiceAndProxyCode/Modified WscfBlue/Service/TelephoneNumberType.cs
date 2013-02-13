namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TelephoneNumberType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class TelephoneNumberType : ComplexObjectType
    {
        
        private ComplexObjectType[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FullTelephoneNumber", typeof(FullTelephoneNumberType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("InternationalTelephoneNumber", typeof(InternationalTelephoneNumberType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("NANPTelephoneNumber", typeof(NANPTelephoneNumberType), IsNullable=true, Order=0)]
        public ComplexObjectType[] Items
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
    }
}
