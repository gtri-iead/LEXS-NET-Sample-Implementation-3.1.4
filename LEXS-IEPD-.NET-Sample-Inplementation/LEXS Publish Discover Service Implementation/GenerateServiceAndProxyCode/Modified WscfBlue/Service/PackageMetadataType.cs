namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class PackageMetadataType : MetadataType
    {
        
        private @string dataItemIDField;
        
        private boolean dataItemCompleteIndicatorField;
        
        private DataContactType[] dataItemContactField;
        
        private date dataItemDateField;
        
        private @string dataItemLEXSVersionField;
        
        private @string dataItemReferenceIDField;
        
        private DataItemPublishInstructionCodeType dataItemPublishInstructionField;
        
        private @string dataItemStatusField;
        
        private DataOwnerMetadataType dataOwnerMetadataField;
        
        private object itemField;
        
        private DataItemCategoryType[] dataItemCategoryField;
        
        private DomainAttributeType[] domainAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string DataItemID
        {
            get
            {
                return this.dataItemIDField;
            }
            set
            {
                this.dataItemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public boolean DataItemCompleteIndicator
        {
            get
            {
                return this.dataItemCompleteIndicatorField;
            }
            set
            {
                this.dataItemCompleteIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataItemContact", IsNullable=true, Order=2)]
        public DataContactType[] DataItemContact
        {
            get
            {
                return this.dataItemContactField;
            }
            set
            {
                this.dataItemContactField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public date DataItemDate
        {
            get
            {
                return this.dataItemDateField;
            }
            set
            {
                this.dataItemDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public @string DataItemLEXSVersion
        {
            get
            {
                return this.dataItemLEXSVersionField;
            }
            set
            {
                this.dataItemLEXSVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public @string DataItemReferenceID
        {
            get
            {
                return this.dataItemReferenceIDField;
            }
            set
            {
                this.dataItemReferenceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public DataItemPublishInstructionCodeType DataItemPublishInstruction
        {
            get
            {
                return this.dataItemPublishInstructionField;
            }
            set
            {
                this.dataItemPublishInstructionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public @string DataItemStatus
        {
            get
            {
                return this.dataItemStatusField;
            }
            set
            {
                this.dataItemStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public DataOwnerMetadataType DataOwnerMetadata
        {
            get
            {
                return this.dataOwnerMetadataField;
            }
            set
            {
                this.dataOwnerMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DisseminationCriteria", typeof(DisseminationCriteriaCodeType), Order=9)]
        [System.Xml.Serialization.XmlElementAttribute("DisseminationCriteriaValue", typeof(DisseminationCriteriaValueType), Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute("DataItemCategory", Order=10)]
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
