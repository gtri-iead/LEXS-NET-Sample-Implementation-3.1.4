namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class TextSearchType : ComplexObjectType
    {
        
        private boolean exactPhraseIndicatorField;
        
        private boolean logicalOperatorIndicatorField;
        
        private boolean wildcardIndicatorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public boolean ExactPhraseIndicator
        {
            get
            {
                return this.exactPhraseIndicatorField;
            }
            set
            {
                this.exactPhraseIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public boolean LogicalOperatorIndicator
        {
            get
            {
                return this.logicalOperatorIndicatorField;
            }
            set
            {
                this.logicalOperatorIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
    }
}
