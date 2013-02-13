namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class SearchResponseMessageType : ResponseMessageType
    {
        
        private SearchResponseMetadataType searchResponseMetadataField;
        
        private SearchResultPackageType[] searchResultPackageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SearchResponseMetadataType SearchResponseMetadata
        {
            get
            {
                return this.searchResponseMetadataField;
            }
            set
            {
                this.searchResponseMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchResultPackage", Order=1)]
        public SearchResultPackageType[] SearchResultPackage
        {
            get
            {
                return this.searchResultPackageField;
            }
            set
            {
                this.searchResultPackageField = value;
            }
        }
    }
}
