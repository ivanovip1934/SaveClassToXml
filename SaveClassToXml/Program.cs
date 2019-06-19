using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace SaveClassToXml
{
     class Program
    {
        static void Main(string[] args)
        {
            TestClass tc = new TestClass();
            tc.PathToMsiX64 = @"\\fileserv.omsu.vmr\soft_distribution$\7-zip\1900\7z-x64.msi";
            tc.PathToMsiX86 = @"\\fileserv.omsu.vmr\soft_distribution$\7-zip\1900\7z.msi";
            tc.Property = "";
            tc.ForceRestart = false;



                string pathToXml = @"C:\programs\!!!!\conf.xml";
                XmlSerializer serializer = new XmlSerializer(typeof(TestClass));
            TextWriter writer = new StreamWriter(pathToXml);
            serializer.Serialize(writer, tc);
            writer.Close();



        }
    }
}
