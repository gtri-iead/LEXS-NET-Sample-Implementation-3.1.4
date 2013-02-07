namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TextSearchRequestMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StructuredSearchRequestMessageType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class SearchRequestMessageType : RequestMessageType
    {
        
        private SearchRequestMetadataType searchRequestMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SearchRequestMetadataType SearchRequestMetadata
        {
            get
            {
                return this.searchRequestMetadataField;
            }
            set
            {
                this.searchRequestMetadataField = value;
            }
        }
    }
}
