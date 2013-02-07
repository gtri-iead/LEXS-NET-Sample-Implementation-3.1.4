namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ItemValueType : ComplexObjectType
    {
        
        private AmountType itemValueAmountField;
        
        private DateType itemValueDateField;
        
        private TextType itemValueDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public AmountType ItemValueAmount
        {
            get
            {
                return this.itemValueAmountField;
            }
            set
            {
                this.itemValueAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public DateType ItemValueDate
        {
            get
            {
                return this.itemValueDateField;
            }
            set
            {
                this.itemValueDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType ItemValueDescriptionText
        {
            get
            {
                return this.itemValueDescriptionTextField;
            }
            set
            {
                this.itemValueDescriptionTextField = value;
            }
        }
    }
}
