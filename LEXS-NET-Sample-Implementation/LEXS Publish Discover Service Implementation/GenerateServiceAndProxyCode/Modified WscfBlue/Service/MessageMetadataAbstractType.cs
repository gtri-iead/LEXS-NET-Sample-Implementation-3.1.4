namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SRMessageMetadataType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PDMessageMetadataType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    public partial class MessageMetadataAbstractType : MetadataType
    {
        
        private @string lEXSVersionField;
        
        private dateTime messageDateTimeField;
        
        private nonNegativeInteger messageSequenceNumberField;
        
        private @string dataSensitivityField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public @string LEXSVersion
        {
            get
            {
                return this.lEXSVersionField;
            }
            set
            {
                this.lEXSVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public dateTime MessageDateTime
        {
            get
            {
                return this.messageDateTimeField;
            }
            set
            {
                this.messageDateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public nonNegativeInteger MessageSequenceNumber
        {
            get
            {
                return this.messageSequenceNumberField;
            }
            set
            {
                this.messageSequenceNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public @string DataSensitivity
        {
            get
            {
                return this.dataSensitivityField;
            }
            set
            {
                this.dataSensitivityField = value;
            }
        }
    }
}
