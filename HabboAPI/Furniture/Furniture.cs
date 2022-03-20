using System.Xml.Serialization;

namespace HabboAPI.Furniture;

public class Furniture
{
    [XmlAttribute("id")]
    public uint Id { get; set; }

    [XmlAttribute("classname")]
    public string ClassName { get; set; }

    [XmlElement("revision")]
    public uint Revision { get; set; }

    [XmlElement("category")]
    public string Category { get; set; }

    [XmlElement("name")]
    public string Name { get; set; }

    [XmlElement("description")]
    public string Description { get; set; }

    [XmlElement("adurl")]
    public string AdUrl { get; set; }

    [XmlElement("offerid")]
    public int OfferId { get; set; }

    [XmlElement("buyout")]
    public bool BuyOut { get; set; }

    [XmlElement("rentofferid")]
    public int RentOfferId { get; set; }

    [XmlElement("rentbuyout")]
    public bool RentBuyOut { get; set; }

    [XmlElement("bc")]
    public bool Bc { get; set; }

    [XmlElement("excludeddynamic")]
    public bool ExcludedDynamic { get; set; }

    [XmlElement("specialtype")]
    public int SpecialType { get; set; }

    [XmlElement("furniline")]
    public string FurniLine { get; set; }

    [XmlElement("environment")]
    public string Environment { get; set; }

    [XmlElement("rare")]
    public bool Rare { get; set; }
}