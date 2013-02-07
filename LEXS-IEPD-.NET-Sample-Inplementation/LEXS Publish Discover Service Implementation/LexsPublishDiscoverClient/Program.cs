using System;
using System.Text;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Configuration;
using System.Runtime.Serialization;
using System.ServiceModel;
using LexsPublishDiscoverWebService;
using XmlSerializationUtils;

namespace LexsPublishDiscoverClientProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ILEXSPublishDiscoverPortType proxy = CreateChannelProxy();

                string sampleInstancePath = ConfigurationManager.AppSettings["SamplesFolder"];

                string sampleXmlInstance = ConfigurationManager.AppSettings["SampleXmlInstance"];

                DoPublishDiscover(proxy, sampleInstancePath, sampleXmlInstance);
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

        private static ILEXSPublishDiscoverPortType CreateChannelProxy()
        {
            string serviceAddress = ConfigurationManager.AppSettings["ServiceEndpointAddress"];
            EndpointAddress ep = new EndpointAddress(serviceAddress);

            BasicHttpBinding binding = new BasicHttpBinding();

            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferSize = 2147483647;
            binding.MaxBufferPoolSize = 2147483647;

            XmlDictionaryReaderQuotas readerQuotas = new XmlDictionaryReaderQuotas();
            readerQuotas.MaxDepth = 2147483647;
            readerQuotas.MaxStringContentLength = 2147483647;
            readerQuotas.MaxArrayLength = 2147483647;
            readerQuotas.MaxBytesPerRead = 2147483647;
            readerQuotas.MaxNameTableCharCount = 2147483647;
            binding.ReaderQuotas = readerQuotas;
            
            ILEXSPublishDiscoverPortType proxy = ChannelFactory<ILEXSPublishDiscoverPortType>.CreateChannel(binding, ep);
            return proxy;
        }

        private static void DoPublishDiscover(ILEXSPublishDiscoverPortType proxy, string sampleInstancePath, string sampleXmlInstance)
        {
            DoPublishType requestType = Deserialize(sampleInstancePath,
                sampleXmlInstance, "doPublish", "http://usdoj.gov/leisp/lexs/publishdiscover/3.1",
                typeof(DoPublishType)) as DoPublishType;

            doPublish message = new doPublish(requestType.PublishMessageContainer);

            proxy.doPublish(message);
       }

        private static object Deserialize(string sampleInstancePath, string inputXmlFileName, string rootElementName, string rootElementNamespace, Type rootElementType)
        {
            string xmlFilePath = sampleInstancePath + Path.DirectorySeparatorChar + inputXmlFileName;
            bool xmlFileExists = File.Exists(xmlFilePath);

            string xmlText = SerializationUtils.XmlStringFromFile(xmlFilePath);

            return SerializationUtils.DeserializeFromXmlString(xmlText, rootElementName, rootElementNamespace, rootElementType);
        }

    }
}
