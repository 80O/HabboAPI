using System.Xml.Serialization;

namespace HabboAPI.Furniture;

public class FloorFurniture : Furniture
{
    [XmlElement("xdim")]
    public uint XDim { get; set; }

    [XmlElement("ydim")]
    public uint YDim { get; set; }

    [XmlArray("partcolors")]
    [XmlArrayItem("color")]
    public string[] PartColors { get; set; }

    [XmlElement("customparams")]
    public string CustomParams { get; set; }

    [XmlElement("canstandon")]
    public bool CanStandOn { get; set; }

    [XmlElement("canlayon")]
    public bool CanLayOn { get; set; }
}