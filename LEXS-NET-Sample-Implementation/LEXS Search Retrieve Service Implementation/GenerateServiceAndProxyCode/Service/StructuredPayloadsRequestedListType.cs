namespace LexsSearchRetrieveWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class StructuredPayloadsRequestedListType : ComplexObjectType
    {
        
        private StructuredPayloadMetadataType[] structuredPayloadMetadataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StructuredPayloadMetadata", Order=0)]
        public StructuredPayloadMetadataType[] StructuredPayloadMetadata
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
    }
}
