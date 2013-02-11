using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Configuration;
using System.ServiceModel;
using XmlSerializationUtils;
using LexsSearchRetrieveWebService;

namespace LexsSRClientProxyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ILEXSSearchRetrievePortType proxy = CreateChannelProxy();

                string sampleInstancePath = ConfigurationManager.AppSettings["SamplesFolder"];
                string sampleXmlInstance = ConfigurationManager.AppSettings["SampleXmlInstance"];

                DoStructureSearchRequest(proxy, sampleInstancePath, sampleXmlInstance);
            }
            catch (Exception e)
            {
                SerializationUtils.PrintInnerExceptions(e);
            }
            finally
            {
                Console.WriteLine("Press <ENTER> to terminate the client...");
                Console.ReadLine();
            }
        }

        private static ILEXSSearchRetrievePortType CreateChannelProxy()
        {
            string serviceAddress = ConfigurationManager.AppSettings["ServiceEndpointAddress"];
            EndpointAddress ep = new EndpointAddress(serviceAddress);

            BasicHttpBinding binding = new BasicHttpBinding();
            XmlDictionaryReaderQuotas readerQuotas = new XmlDictionaryReaderQuotas();
            readerQuotas.MaxDepth = 2147483647;
            readerQuotas.MaxStringContentLength = 2147483647;
            readerQuotas.MaxArrayLength = 2147483647;
            readerQuotas.MaxBytesPerRead = 2147483647;
            readerQuotas.MaxNameTableCharCount = 2147483647;

            binding.ReaderQuotas = readerQuotas;
            ILEXSSearchRetrievePortType proxy = ChannelFactory<ILEXSSearchRetrievePortType>.CreateChannel(binding, ep);
            return proxy;
        }

        private static void DoStructureSearchRequest(ILEXSSearchRetrievePortType proxy, string sampleInstancePath, string sampleXmlInstance)
        {
            doStructuredSearchRequestType requestType = Deserialize(sampleInstancePath,
                sampleXmlInstance, "doStructuredSearchRequest", "http://usdoj.gov/leisp/lexs/searchretrieve/3.1",
                typeof(doStructuredSearchRequestType)) as doStructuredSearchRequestType;
            doStructuredSearchRequest request = new doStructuredSearchRequest(requestType.StructuredSearchRequestMessage);
            doStructuredSearchResponse reponse = proxy.doStructuredSearch(request);
            SaveResponse(reponse, sampleInstancePath);
        }

        private static void SaveResponse(doStructuredSearchResponse response, string samplesDir)
        {
            doSearchResponseType doSearchResponseType = new doSearchResponseType();
            doSearchResponseType.SearchResponseMessage = response.SearchResponseMessage;

            string xmlResponse = SerializationUtils.SerializeToXmlString(doSearchResponseType,
                "doSearchResponse", "http://usdoj.gov/leisp/lexs/searchretrieve/3.1");

            string xmlFilePath = samplesDir + Path.DirectorySeparatorChar + "SearchRetrieveResponse.xml";

            XmlDocument outputXmlDoc = new XmlDocument();
            outputXmlDoc.LoadXml(xmlResponse);

            outputXmlDoc.Save(xmlFilePath);

            Console.WriteLine("The response was saved to : " + xmlFilePath);
        }

        private static object Deserialize(string sampleInstancePath, string inputXmlFileName, 
            string rootElementName, string rootElementNamespace, Type rootElementType)
        {
            string xmlFilePath = sampleInstancePath + Path.DirectorySeparatorChar + inputXmlFileName;
            bool xmlFileExists = File.Exists(xmlFilePath);

            string xmlText = SerializationUtils.XmlStringFromFile(xmlFilePath);

            return SerializationUtils.DeserializeFromXmlString(xmlText, rootElementName, rootElementNamespace, rootElementType);
        }

    }
}
