namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class ActivityType : ComplexObjectType
    {
        
        private IdentificationType activityIdentificationField;
        
        private TextType activityCategoryTextField;
        
        private ComplexObjectType itemField;
        
        private TextType[] activityDescriptionTextField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public IdentificationType ActivityIdentification
        {
            get
            {
                return this.activityIdentificationField;
            }
            set
            {
                this.activityIdentificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public TextType ActivityCategoryText
        {
            get
            {
                return this.activityCategoryTextField;
            }
            set
            {
                this.activityCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActivityDate", typeof(DateType), IsNullable=true, Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("ActivityDateRange", typeof(DateRangeType), IsNullable=true, Order=2)]
        public ComplexObjectType Item
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
        [System.Xml.Serialization.XmlElementAttribute("ActivityDescriptionText", IsNullable=true, Order=3)]
        public TextType[] ActivityDescriptionText
        {
            get
            {
                return this.activityDescriptionTextField;
            }
            set
            {
                this.activityDescriptionTextField = value;
            }
        }
    }
}
