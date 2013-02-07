namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class CapabilitiesType : ComplexObjectType
    {
        
        private DataItemCategoryType[] dataItemCategoryField;
        
        private boolean pagingIndicatorField;
        
        private nonNegativeInteger maxHitsReturnedField;
        
        private StructuredSearchType structuredSearchField;
        
        private TextSearchType textSearchField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategory", Order=0)]
        public DataItemCategoryType[] DataItemCategory
        {
            get
            {
                return this.dataItemCategoryField;
            }
            set
            {
                this.dataItemCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public boolean PagingIndicator
        {
            get
            {
                return this.pagingIndicatorField;
            }
            set
            {
                this.pagingIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public nonNegativeInteger MaxHitsReturned
        {
            get
            {
                return this.maxHitsReturnedField;
            }
            set
            {
                this.maxHitsReturnedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public StructuredSearchType StructuredSearch
        {
            get
            {
                return this.structuredSearchField;
            }
            set
            {
                this.structuredSearchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public TextSearchType TextSearch
        {
            get
            {
                return this.textSearchField;
            }
            set
            {
                this.textSearchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DomainAttribute", Order=5)]
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
