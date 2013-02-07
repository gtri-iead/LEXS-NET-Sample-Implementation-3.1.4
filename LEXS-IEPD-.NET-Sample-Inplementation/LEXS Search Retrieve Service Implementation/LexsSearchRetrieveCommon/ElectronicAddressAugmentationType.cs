namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/digest/3.1")]
    public partial class ElectronicAddressAugmentationType : AugmentationType
    {
        
        private DateType[] electronicAddressCaptureDateField;
        
        private TextType electronicAddressDescriptionTextField;
        
        private TextType electronicAddressMACNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ElectronicAddressCaptureDate", IsNullable=true, Order=0)]
        public DateType[] ElectronicAddressCaptureDate
        {
            get
            {
                return this.electronicAddressCaptureDateField;
            }
            set
            {
                this.electronicAddressCaptureDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType ElectronicAddressDescriptionText
        {
            get
            {
                return this.electronicAddressDescriptionTextField;
            }
            set
            {
                this.electronicAddressDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType ElectronicAddressMACNumber
        {
            get
            {
                return this.electronicAddressMACNumberField;
            }
            set
            {
                this.electronicAddressMACNumberField = value;
            }
        }
    }
}
