using System.Collections;
using System.Xml.Serialization;

namespace HabboAPI.Furniture
{
    [XmlRoot("furnidata")]
    public class FurniData : IEnumerable<Furniture>
    {
        private List<Furniture>? _allFurniture;

        [XmlArray("roomitemtypes")]
        [XmlArrayItem("furnitype")]
        public List<FloorFurniture> FloorItems { get; set; }

        [XmlArray("wallitemtypes")]
        [XmlArrayItem("furnitype")]
        public List<WallFurniture> WallItems { get; set; }

        public IEnumerator<Furniture> GetEnumerator()
        {
            _allFurniture ??= FloorItems.Cast<Furniture>().Concat(WallItems.Cast<Furniture>()).ToList();
            return _allFurniture.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
