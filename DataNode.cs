
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Warehouse
{
    public class DataNode
    {   
        [XmlAttribute]
        public string Text { get; set; }
        [XmlAttribute]
        public bool IsSelected { get; set; }
        [XmlAttribute]
        public bool IsExpanded { get; set; }    
        [XmlElement("DataNode")]
        public List<DataNode> Nodes { get; set;} = new List<DataNode>();
    }
}
