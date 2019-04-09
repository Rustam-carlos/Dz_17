using System;
using System.Xml.Serialization;
using System.Xml;


namespace Dz_17
{
    [Serializable]
    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [XmlElement(ElementName = "title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "link")]
        public string Link { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "pubdate")]
        public DateTime PubDate { get; set; }
        public Item()
        {

        }
    }
}
