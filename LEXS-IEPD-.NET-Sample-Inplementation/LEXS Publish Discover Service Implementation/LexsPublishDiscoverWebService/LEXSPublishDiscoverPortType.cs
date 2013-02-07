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

namespace LexsPublishDiscoverWebService
{
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class LEXSPublishDiscoverPortType : ILEXSPublishDiscoverPortType
    {
        #region ILEXSPublishDiscoverPortType Members

        public virtual void doPublish(doPublish request)
        {
            try
            {
                string appDataDir = HostingEnvironment.ApplicationPhysicalPath;

                string samplesFolder = ConfigurationManager.AppSettings["SamplesFolder"];

                string samplesDir = string.Empty;

                if (appDataDir == null)
                {
                    samplesDir = samplesFolder;
                }
                else
                {
                    samplesDir = appDataDir + Path.DirectorySeparatorChar + samplesFolder;
                }

                DoPublishType publish = new DoPublishType();
                publish.PublishMessageContainer = request.PublishMessageContainer;

                string xmlPublish = SerializationUtils.SerializeToXmlString(publish,
                    "doPublish", "http://usdoj.gov/leisp/lexs/publishdiscover/3.1");


                string xmlFilePath = samplesDir + Path.DirectorySeparatorChar + "PublishDiscoverRequest.xml";

                XmlDocument outputXmlDoc = new XmlDocument();
                outputXmlDoc.LoadXml(xmlPublish);

                outputXmlDoc.Save(xmlFilePath);
            }
            catch (Exception e)
            {
                Debug.WriteLine("Server exception: " + e.ToString());

                throw;
            }
        }

        #endregion
    }
}
