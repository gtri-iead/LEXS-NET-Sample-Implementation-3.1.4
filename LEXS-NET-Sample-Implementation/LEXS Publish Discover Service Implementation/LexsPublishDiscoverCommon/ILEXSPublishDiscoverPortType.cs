namespace LexsPublishDiscoverWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/ws", ConfigurationName="ILEXSPublishDiscoverPortType")]
    public interface ILEXSPublishDiscoverPortType
    {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/publishdiscover/3.1) of message doPublish does not match the default value (http://usdoj.gov/leisp/lexs/publishdiscover/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/doPublish")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(SRMessageType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(DoPublishType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        void doPublish(doPublish request);
    }
}
