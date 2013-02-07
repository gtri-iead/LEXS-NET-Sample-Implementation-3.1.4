namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class StructuredPayloadMetadataType : MetadataType
    {
        
        private AnyURIType communityURIField;
        
        private @string communityDescriptionField;
        
        private @string communityVersionField;
        
        private CommunityPedigreeURIType[] communityPedigreeURIField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AnyURIType CommunityURI
        {
            get
            {
                return this.communityURIField;
            }
            set
            {
                this.communityURIField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public @string CommunityDescription
        {
            get
            {
                return this.communityDescriptionField;
            }
            set
            {
                this.communityDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public @string CommunityVersion
        {
            get
            {
                return this.communityVersionField;
            }
            set
            {
                this.communityVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommunityPedigreeURI", Order=3)]
        public CommunityPedigreeURIType[] CommunityPedigreeURI
        {
            get
            {
                return this.communityPedigreeURIField;
            }
            set
            {
                this.communityPedigreeURIField = value;
            }
        }
    }
}
