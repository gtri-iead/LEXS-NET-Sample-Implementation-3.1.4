namespace LexsPublishDiscoverWebService
{
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("WscfGen", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://usdoj.gov/leisp/lexs/publishdiscover/3.1")]
    public partial class DoPublishType
    {
        
        private PublishMessageType[] publishMessageContainerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PublishMessage", IsNullable=false)]
        public PublishMessageType[] PublishMessageContainer
        {
            get
            {
                return this.publishMessageContainerField;
            }
            set
            {
                this.publishMessageContainerField = value;
            }
        }
    }
}
