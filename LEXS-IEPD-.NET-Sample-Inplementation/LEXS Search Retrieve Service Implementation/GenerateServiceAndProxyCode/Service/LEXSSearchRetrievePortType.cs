namespace LexsSearchRetrieveWebService
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class LEXSSearchRetrievePortType : ILEXSSearchRetrievePortType
    {
        
        public virtual doStructuredSearchResponse doStructuredSearch(doStructuredSearchRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual doStructuredSearchResponse doTextSearch(doTextSearchRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getDataItemResponse getDataItem(getDataItemRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getAttachmentResponse getAttachment(getAttachmentRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getCapabilitiesResponse getCapabilities(getCapabilitiesRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getDataOwnersResponse getDataOwners(getDataOwnersRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getAvailabilityResponse getAvailability(getAvailabilityRequest request)
        {
            throw new System.NotImplementedException();
        }
        
        public virtual getDomainResponse getDomain(getDomainRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
