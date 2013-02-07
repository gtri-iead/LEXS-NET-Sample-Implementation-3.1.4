namespace LexsPublishDiscoverWebService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doPublish", WrapperNamespace="http://usdoj.gov/leisp/lexs/publishdiscover/3.1", IsWrapped=true)]
    public partial class doPublish
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("PublishMessage", IsNullable=false)]
        public PublishMessageType[] PublishMessageContainer;
        
        public doPublish()
        {
        }
        
        public doPublish(PublishMessageType[] PublishMessageContainer)
        {
            this.PublishMessageContainer = PublishMessageContainer;
        }
    }
}
