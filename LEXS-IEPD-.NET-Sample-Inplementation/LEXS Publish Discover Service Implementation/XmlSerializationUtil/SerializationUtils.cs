using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace XmlSerializationUtils
{
    // Overrides the Encoding property
    public class Utf8StringWriter : StringWriter
    {
        public override Encoding Encoding
        {
            get { return Encoding.UTF8; }
        }
    }

    public class SerializationUtils
    {
        public static string XmlStringFromFile(string strXmlFile)
        {
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(strXmlFile);
            }
            catch (XmlException e)
            {
                Debug.WriteLine("Exception: " + e.Message);
            }

            StringWriter sw = new StringWriter();
            XmlTextWriter xw = new XmlTextWriter(sw);

            xmlDoc.WriteTo(xw);

            return sw.ToString();
        }

        public static string SerializeToXmlString(object targetInstance, string rootElementName, string rootNamespaceName)
        {
            string retVal = string.Empty;
            TextWriter writer = new Utf8StringWriter();

            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = rootElementName;
            xRoot.Namespace = rootNamespaceName;
            xRoot.IsNullable = true;

            XmlSerializer serializer = new XmlSerializer(targetInstance.GetType(), xRoot);
            serializer.Serialize(writer, targetInstance);
            retVal = writer.ToString();

            return retVal;
        }

        public static object DeserializeFromXmlString(string objectXml, string rootElementName, string rootNamespaceName, Type targetType)
        {
            object retVal = null;

            try
            {
                // Need to read it to bytes, to undo the fact that strings are UTF-16 all the time.
                // We want it to handle it as UTF8.
                byte[] bytes = Encoding.UTF8.GetBytes(objectXml);

                using (MemoryStream memStream = new MemoryStream(bytes))
                {
                    XmlRootAttribute xRoot = new XmlRootAttribute();
                    xRoot.ElementName = rootElementName;
                    xRoot.Namespace = rootNamespaceName;
                    xRoot.IsNullable = false;

                    XmlSerializer serializer = new XmlSerializer(targetType, xRoot);

                    serializer.UnknownAttribute += new XmlAttributeEventHandler(Serializer_UnknownAttribute);
                    serializer.UnknownElement += new XmlElementEventHandler(Serializer_OnUnknownElement);
                    serializer.UnknownNode += new XmlNodeEventHandler(Serializer_OnUnknownNode);
                    serializer.UnreferencedObject += new UnreferencedObjectEventHandler(Serializer_UnreferencedObject);

                    retVal = serializer.Deserialize(memStream);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine("DeserializeFromXmlString = " + targetType.ToString());

                Debug.WriteLine("Exception = " + e.Message);
                PrintInnerExceptions(e.InnerException);
            }
            return retVal;
        }

        public static void PrintInnerExceptions(Exception e)
        {
            Debug.WriteLine("InnerException = " + e.Message);
            if (e.InnerException != null)
            {
                PrintInnerExceptions(e.InnerException);
            }
        }

        private static void Serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("DateTime: " + DateTime.Now.ToString());


            Console.WriteLine("Unknown Attribute");
            Console.WriteLine("\t" + e.Attr.Name + " " + e.Attr.InnerXml);
            Console.WriteLine("\t LineNumber: " + e.LineNumber);
            Console.WriteLine("\t LinePosition: " + e.LinePosition);
        }

        private static void Serializer_OnUnknownElement(object sender, XmlElementEventArgs e)
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("DateTime: " + DateTime.Now.ToString());

            Console.WriteLine("Unknown Element");
            Console.WriteLine("\t" + e.Element.Name + " " + e.Element.InnerXml);
            Console.WriteLine("\t LineNumber: " + e.LineNumber);
            Console.WriteLine("\t LinePosition: " + e.LinePosition);
        }

        private static void Serializer_OnUnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("DateTime: " + DateTime.Now.ToString());

            Console.WriteLine("Unknown Node");
            Console.WriteLine("\t" + e.Name + " " + e.Text);
            Console.WriteLine("\t LineNumber: " + e.LineNumber);
            Console.WriteLine("\t LinePosition: " + e.LinePosition);
        }

        private static void Serializer_UnreferencedObject(object sender, UnreferencedObjectEventArgs e)
        {
            Console.WriteLine("_________________________________________");
            Console.WriteLine("DateTime: " + DateTime.Now.ToString());

            Console.WriteLine("Unknown Element");
            Console.WriteLine("\t" + e.UnreferencedId + " " + e.UnreferencedObject.ToString());
        }                      
    }
}
