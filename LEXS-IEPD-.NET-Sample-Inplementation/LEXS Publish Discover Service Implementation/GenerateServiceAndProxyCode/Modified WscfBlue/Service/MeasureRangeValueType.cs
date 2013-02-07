namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://niem.gov/niem/niem-core/2.0")]
    public partial class MeasureRangeValueType : ComplexObjectType
    {
        
        private @decimal rangeMinimumValueField;
        
        private @decimal rangeMaximumValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public @decimal RangeMinimumValue
        {
            get
            {
                return this.rangeMinimumValueField;
            }
            set
            {
                this.rangeMinimumValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public @decimal RangeMaximumValue
        {
            get
            {
                return this.rangeMaximumValueField;
            }
            set
            {
                this.rangeMaximumValueField = value;
            }
        }
    }
}
