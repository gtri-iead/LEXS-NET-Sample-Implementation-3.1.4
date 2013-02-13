namespace LexsSearchRetrieveWebService
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCapabilitiesResponse", WrapperNamespace="http://usdoj.gov/leisp/lexs/searchretrieve/3.1", IsWrapped=true)]
    public partial class getCapabilitiesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://usdoj.gov/leisp/lexs/3.1", Order=0)]
        public CapabilitiesResponseMessageType CapabilitiesResponseMessage;
        
        public getCapabilitiesResponse()
        {
        }
        
        public getCapabilitiesResponse(CapabilitiesResponseMessageType CapabilitiesResponseMessage)
        {
            this.CapabilitiesResponseMessage = CapabilitiesResponseMessage;
        }
    }
}
