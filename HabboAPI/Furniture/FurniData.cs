using System.Xml.Serialization;

namespace HabboAPI.Furniture
{
    [XmlRoot("furnidata")]
    public class FurniData
    {
        private List<Furniture>? _allFurniture;

        [XmlArray("roomitemtypes")]
        [XmlArrayItem("furnitype")]
        public List<FloorFurniture> FloorItems { get; set; }

        [XmlArray("wallitemtypes")]
        [XmlArrayItem("furnitype")]
        public List<WallFurniture> WallItems { get; set; }

        public IEnumerable<Furniture> Furniture => _allFurniture ??= FloorItems.Concat(WallItems.Cast<Furniture>()).ToList();
    }
}
