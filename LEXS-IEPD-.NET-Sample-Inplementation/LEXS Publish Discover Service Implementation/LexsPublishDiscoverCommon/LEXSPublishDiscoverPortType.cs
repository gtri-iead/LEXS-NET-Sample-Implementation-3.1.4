namespace LexsPublishDiscoverWebService
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class LEXSPublishDiscoverPortType : ILEXSPublishDiscoverPortType
    {
        
        public virtual void doPublish(doPublish request)
        {
            throw new System.NotImplementedException();
        }
    }
}
