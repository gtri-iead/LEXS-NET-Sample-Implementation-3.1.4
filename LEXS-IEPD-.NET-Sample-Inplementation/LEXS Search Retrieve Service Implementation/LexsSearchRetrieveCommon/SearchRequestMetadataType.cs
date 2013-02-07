namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class SearchRequestMetadataType : MetadataType
    {
        
        private DataCategoryCodeType[] requestedDataField;
        
        private DataOwnerIdentifierType[] dataOwnerIdentifierField;
        
        private nonNegativeInteger maxItemMatchesField;
        
        private @string matchBeginAfterField;
        
        private @string matchEndBeforeField;
        
        private @string serviceProviderSearchIDField;
        
        private @string[] dataItemCategoryTextField;
        
        private SortOrderCodeType sortOrderField;
        
        private duration timeoutDurationField;
        
        private NumberOfStructuredPayloadTermsType[] numberOfStructuredPayloadTermsField;
        
        private object itemField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RequestedData", Order=0)]
        public DataCategoryCodeType[] RequestedData
        {
            get
            {
                return this.requestedDataField;
            }
            set
            {
                this.requestedDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataOwnerIdentifier", Order=1)]
        public DataOwnerIdentifierType[] DataOwnerIdentifier
        {
            get
            {
                return this.dataOwnerIdentifierField;
            }
            set
            {
                this.dataOwnerIdentifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public nonNegativeInteger MaxItemMatches
        {
            get
            {
                return this.maxItemMatchesField;
            }
            set
            {
                this.maxItemMatchesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public @string MatchBeginAfter
        {
            get
            {
                return this.matchBeginAfterField;
            }
            set
            {
                this.matchBeginAfterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public @string MatchEndBefore
        {
            get
            {
                return this.matchEndBeforeField;
            }
            set
            {
                this.matchEndBeforeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategoryText", Order=6)]
        public @string[] DataItemCategoryText
        {
            get
            {
                return this.dataItemCategoryTextField;
            }
            set
            {
                this.dataItemCategoryTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public SortOrderCodeType SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public duration TimeoutDuration
        {
            get
            {
                return this.timeoutDurationField;
            }
            set
            {
                this.timeoutDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NumberOfStructuredPayloadTerms", Order=9)]
        public NumberOfStructuredPayloadTermsType[] NumberOfStructuredPayloadTerms
        {
            get
            {
                return this.numberOfStructuredPayloadTermsField;
            }
            set
            {
                this.numberOfStructuredPayloadTermsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedCode", typeof(StructuredPayloadsRequestedCodeType), Order=10)]
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadsRequestedList", typeof(StructuredPayloadsRequestedListType), Order=10)]
        public object Item
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
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=11)]
        public DomainAttributeType[] DomainAttribute
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
