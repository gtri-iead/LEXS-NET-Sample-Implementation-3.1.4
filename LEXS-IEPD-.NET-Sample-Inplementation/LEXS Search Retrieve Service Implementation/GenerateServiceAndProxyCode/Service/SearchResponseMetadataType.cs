namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class SearchResponseMetadataType : MetadataType
    {
        
        private string structuredQueryMatchScoreField;
        
        private nonNegativeInteger maxItemMatchesRequestedField;
        
        private @string numberItemMatchesField;
        
        private boolean serverLimitIndicatorField;
        
        private @string matchBeginPointField;
        
        private @string matchEndPointField;
        
        private @string serviceProviderSearchIDField;
        
        private DomainAttributeType domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="nonNegativeInteger", Order=0)]
        public string StructuredQueryMatchScore
        {
            get
            {
                return this.structuredQueryMatchScoreField;
            }
            set
            {
                this.structuredQueryMatchScoreField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public nonNegativeInteger MaxItemMatchesRequested
        {
            get
            {
                return this.maxItemMatchesRequestedField;
            }
            set
            {
                this.maxItemMatchesRequestedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public @string NumberItemMatches
        {
            get
            {
                return this.numberItemMatchesField;
            }
            set
            {
                this.numberItemMatchesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public boolean ServerLimitIndicator
        {
            get
            {
                return this.serverLimitIndicatorField;
            }
            set
            {
                this.serverLimitIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public @string MatchBeginPoint
        {
            get
            {
                return this.matchBeginPointField;
            }
            set
            {
                this.matchBeginPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public @string MatchEndPoint
        {
            get
            {
                return this.matchEndPointField;
            }
            set
            {
                this.matchEndPointField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public @string ServiceProviderSearchID
        {
            get
            {
                return this.serviceProviderSearchIDField;
            }
            set
            {
                this.serviceProviderSearchIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public DomainAttributeType DomainAttribute
        {
            get
            {
                return this.domainAttributeField;
            }
            set
            {
                this.domainAttributeField = value;
            }
        }
    }
}
