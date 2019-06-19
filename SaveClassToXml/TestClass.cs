using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace SaveClassToXml
{
    [XmlRoot("TestClass",IsNullable =false)]
    [Serializable]
    public class TestClass
    {
        public string PathToMsiX86 { get; set; }
        public string PathToMsiX64 { get; set; }
        public string Property { get; set; }
        public bool ForceRestart { get; set; }
        
    }
}
