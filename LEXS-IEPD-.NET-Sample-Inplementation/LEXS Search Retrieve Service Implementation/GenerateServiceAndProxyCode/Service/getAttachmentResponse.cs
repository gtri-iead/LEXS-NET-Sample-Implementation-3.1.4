namespace LexsSearchRetrieveWebService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getAttachmentResponse", WrapperNamespace="http://usdoj.gov/leisp/lexs/searchretrieve/3.1", IsWrapped=true)]
    public partial class getAttachmentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1", Order=0)]
        public AttachmentResponseMessageType AttachmentResponseMessage;
        
        public getAttachmentResponse()
        {
        }
        
        public getAttachmentResponse(AttachmentResponseMessageType AttachmentResponseMessage)
        {
            this.AttachmentResponseMessage = AttachmentResponseMessage;
        }
    }
}
