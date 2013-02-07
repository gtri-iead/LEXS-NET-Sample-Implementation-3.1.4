namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class ResponseMetadataType : MetadataType
    {
        
        private ResultCodeType resultCodeField;
        
        private AdvisoryType[] advisoryField;
        
        private nonNegativeInteger inResponseToMessageSequenceNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResultCodeType ResultCode
        {
            get
            {
                return this.resultCodeField;
            }
            set
            {
                this.resultCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Advisory", Order=1)]
        public AdvisoryType[] Advisory
        {
            get
            {
                return this.advisoryField;
            }
            set
            {
                this.advisoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public nonNegativeInteger InResponseToMessageSequenceNumber
        {
            get
            {
                return this.inResponseToMessageSequenceNumberField;
            }
            set
            {
                this.inResponseToMessageSequenceNumberField = value;
            }
        }
    }
}
