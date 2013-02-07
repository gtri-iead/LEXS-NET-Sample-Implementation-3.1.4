namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class StructuredSearchType : ComplexObjectType
    {
        
        private boolean multipleValueIndicatorField;
        
        private boolean wildcardIndicatorField;
        
        private boolean fuzzySearchIndicatorField;
        
        private boolean dateRangeIndicatorField;
        
        private boolean numericRangeIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public boolean MultipleValueIndicator
        {
            get
            {
                return this.multipleValueIndicatorField;
            }
            set
            {
                this.multipleValueIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public boolean WildcardIndicator
        {
            get
            {
                return this.wildcardIndicatorField;
            }
            set
            {
                this.wildcardIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public boolean FuzzySearchIndicator
        {
            get
            {
                return this.fuzzySearchIndicatorField;
            }
            set
            {
                this.fuzzySearchIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public boolean DateRangeIndicator
        {
            get
            {
                return this.dateRangeIndicatorField;
            }
            set
            {
                this.dateRangeIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public boolean NumericRangeIndicator
        {
            get
            {
                return this.numericRangeIndicatorField;
            }
            set
            {
                this.numericRangeIndicatorField = value;
            }
        }
    }
}
