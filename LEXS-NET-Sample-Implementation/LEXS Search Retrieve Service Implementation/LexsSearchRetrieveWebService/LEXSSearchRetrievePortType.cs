using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Schema;
using System.IO;
using System.Diagnostics;
using System.Web;
using System.Web.Hosting;
using System.Configuration;
using XmlSerializationUtils;


namespace LexsSearchRetrieveWebService
{
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class LEXSSearchRetrievePortType : ILEXSSearchRetrievePortType
    {
        public virtual doStructuredSearchResponse doStructuredSearch(doStructuredSearchRequest request)
        {
            try
            {
                string appDataDir = HostingEnvironment.ApplicationPhysicalPath;

                string samplesFolder = ConfigurationManager.AppSettings["SamplesFolder"];
                
                string sampleInstance = ConfigurationManager.AppSettings["ResponseXmlInstance"];
                
                string samplesDir = string.Empty;

                if (appDataDir == null)
                {
                    samplesDir = samplesFolder;
                }
                else
                {
                    samplesDir = appDataDir + Path.DirectorySeparatorChar + samplesFolder;
                }
                
                SaveRequest(request, samplesDir);

                return GetResponse(request, sampleInstance, samplesDir);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Server exception: " + e.ToString());

                throw e;
            }
        }

        private static void SaveRequest(doStructuredSearchRequest request, string samplesDir)
        {
            doStructuredSearchRequestType requestType = new doStructuredSearchRequestType();
            requestType.StructuredSearchRequestMessage = request.StructuredSearchRequestMessage;

            string xmlPublish = SerializationUtils.SerializeToXmlString(requestType,
                "doStructuredSearchRequest", "http://usdoj.gov/leisp/lexs/searchretrieve/3.1");

            string xmlFilePath = samplesDir + Path.DirectorySeparatorChar + "StructuredSearchRequest.xml";

            XmlDocument outputXmlDoc = new XmlDocument();
            outputXmlDoc.LoadXml(xmlPublish);

            outputXmlDoc.Save(xmlFilePath);
        }

        private static doStructuredSearchResponse GetResponse(doStructuredSearchRequest request, string sampleInstance, string samplesDir)
        {
            string xmlFilePath = samplesDir + Path.DirectorySeparatorChar + "" + sampleInstance ;

            if (!File.Exists(xmlFilePath))
            {
                return null;
            }

            string xmlText = SerializationUtils.XmlStringFromFile(xmlFilePath);

            Type type = typeof(doSearchResponseType);

            doSearchResponseType searchResponseType = SerializationUtils.DeserializeFromXmlString(xmlText,
                "doSearchResponse", "http://usdoj.gov/leisp/lexs/searchretrieve/3.1", type) as doSearchResponseType;
            
            doStructuredSearchResponse structuredSearchResponse = new doStructuredSearchResponse(searchResponseType.SearchResponseMessage);
            
            return structuredSearchResponse;
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
