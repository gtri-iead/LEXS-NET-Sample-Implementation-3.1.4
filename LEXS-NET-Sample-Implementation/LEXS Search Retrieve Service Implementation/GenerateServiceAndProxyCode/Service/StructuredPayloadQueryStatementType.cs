namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class StructuredPayloadQueryStatementType : ComplexObjectType
    {
        
        private StructuredPayloadMetadataType structuredPayloadMetadataField;
        
        private StructuredPayloadQueryFieldType structuredPayloadQueryFieldField;
        
        private QueryMatchCodeType queryMatchField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public StructuredPayloadMetadataType StructuredPayloadMetadata
        {
            get
            {
                return this.structuredPayloadMetadataField;
            }
            set
            {
                this.structuredPayloadMetadataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public StructuredPayloadQueryFieldType StructuredPayloadQueryField
        {
            get
            {
                return this.structuredPayloadQueryFieldField;
            }
            set
            {
                this.structuredPayloadQueryFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
