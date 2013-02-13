namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class DigestQueryStatementType : ComplexObjectType
    {
        
        private DigestQueryFieldType digestQueryFieldField;
        
        private QueryMatchCodeType queryMatchField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DigestQueryFieldType DigestQueryField
        {
            get
            {
                return this.digestQueryFieldField;
            }
            set
            {
                this.digestQueryFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public QueryMatchCodeType QueryMatch
        {
            get
            {
                return this.queryMatchField;
            }
            set
            {
                this.queryMatchField = value;
            }
        }
    }
}
