namespace LexsSearchRetrieveWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws", ConfigurationName="ILEXSSearchRetrievePortType")]
    public interface ILEXSSearchRetrievePortType
    {
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message doStructuredSearchRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/doStructuredSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        doStructuredSearchResponse doStructuredSearch(doStructuredSearchRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message doTextSearchRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/doTextSearch", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        doStructuredSearchResponse doTextSearch(doTextSearchRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message getDataItemRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/getDataItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        getDataItemResponse getDataItem(getDataItemRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message getAttachmentRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/getAttachment", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        getAttachmentResponse getAttachment(getAttachmentRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message getCapabilitiesRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/getCapabilities", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        getCapabilitiesResponse getCapabilities(getCapabilitiesRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message getDataOwnersRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/getDataOwners", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        getDataOwnersResponse getDataOwners(getDataOwnersRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message getAvailabilityRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/getAvailability", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        getAvailabilityResponse getAvailability(getAvailabilityRequest request);
        
        // CODEGEN: Generating message contract since the wrapper namespace (http://usdoj.gov/leisp/lexs/searchretrieve/3.1) of message getDomainRequest does not match the default value (http://usdoj.gov/leisp/lexs/searchretrieve/3.1/ws)
        [System.ServiceModel.OperationContractAttribute(Action="http://usdoj.gov/leisp/lexs/publishdiscover/3.1/getDomain", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(PayloadObjectReferenceType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDomainRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAvailabilityRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataOwnersRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getCapabilitiesRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getAttachmentRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(getDataItemRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doSearchResponseType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doTextSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(AugmentationType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(doStructuredSearchRequestType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(ComplexObjectType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(MetadataType))]
        getDomainResponse getDomain(getDomainRequest request);
    }
}