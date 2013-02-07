namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ContactInformationType : ComplexObjectType
    {
        
        private object[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContactEmailID", typeof(@string), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ContactInstantMessenger", typeof(InstantMessengerType), IsNullable=true, Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ContactTelephoneNumber", typeof(TelephoneNumberType), IsNullable=true, Order=0)]
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
    }
}
