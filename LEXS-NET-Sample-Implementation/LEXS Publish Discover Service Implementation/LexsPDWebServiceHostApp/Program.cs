using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Description;
using LexsPublishDiscoverWebService;

namespace LexsPDWebServiceHostApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(LEXSPublishDiscoverPortType),
                            new Uri("http://localhost:8010/LexsPublishDiscover")))
            {
                BasicHttpBinding binding = CreateBinding();

                host.AddServiceEndpoint(typeof(ILEXSPublishDiscoverPortType), binding, "LEXSPublishDiscoverPortType");

                AddServiceMetadataBehavior(host);

                host.Open();

                Console.WriteLine("Press <ENTER> to terminate the service host...");
                Console.ReadLine();
            }
        }

        private static BasicHttpBinding CreateBinding()
        {
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
            return binding;
        }

        private static void AddServiceMetadataBehavior(ServiceHost host)
        {
            ServiceMetadataBehavior mexBehavior = host.Description.Behaviors.Find<ServiceMetadataBehavior>();

            if (mexBehavior == null)
            {
                mexBehavior = new ServiceMetadataBehavior();
                mexBehavior.HttpGetEnabled = true;
                host.Description.Behaviors.Add(mexBehavior);
            }
        }
    }
}
