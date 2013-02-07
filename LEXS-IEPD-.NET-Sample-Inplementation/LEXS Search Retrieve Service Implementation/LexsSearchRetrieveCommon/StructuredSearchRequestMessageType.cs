namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class StructuredSearchRequestMessageType : SearchRequestMessageType
    {
        
        private StructuredQueryType[] structuredQueryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredQuery", Order=0)]
        public StructuredQueryType[] StructuredQuery
        {
            get
            {
                return this.structuredQueryField;
            }
            set
            {
                this.structuredQueryField = value;
            }
        }
    }
}
