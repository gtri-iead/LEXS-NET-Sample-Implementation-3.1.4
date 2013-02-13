namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElectronicAddressType1))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/domains/screening/2.0")]
    public partial class ElectronicAddressType : ComplexObjectType
    {
        
        private TextType electronicAddressTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public TextType ElectronicAddressText
        {
            get
            {
                return this.electronicAddressTextField;
            }
            set
            {
                this.electronicAddressTextField = value;
            }
        }
    }
}
