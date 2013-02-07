namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1")]
    [System.Xml.Serialization.XmlRootAttribute("PublishMessageContainer", Namespace="http://usdoj.gov/leisp/lexs/3.1", IsNullable=false)]
    public partial class PublishMessageContainerType
    {
        
        private PublishMessageType[] publishMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PublishMessage")]
        public PublishMessageType[] PublishMessage
        {
            get
            {
                return this.publishMessageField;
            }
            set
            {
                this.publishMessageField = value;
            }
        }
    }
}
