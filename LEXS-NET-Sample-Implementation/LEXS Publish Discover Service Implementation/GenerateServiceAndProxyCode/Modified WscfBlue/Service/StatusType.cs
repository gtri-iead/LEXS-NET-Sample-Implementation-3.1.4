namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MarriageStatusType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class StatusType : ComplexObjectType
    {
        
        private DateType statusDateField;
        
        private TextType statusDescriptionTextField;
        
        private TextType statusIssuerTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public DateType StatusDate
        {
            get
            {
                return this.statusDateField;
            }
            set
            {
                this.statusDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType StatusDescriptionText
        {
            get
            {
                return this.statusDescriptionTextField;
            }
            set
            {
                this.statusDescriptionTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public TextType StatusIssuerText
        {
            get
            {
                return this.statusIssuerTextField;
            }
            set
            {
                this.statusIssuerTextField = value;
            }
        }
    }
}
