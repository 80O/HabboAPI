using System.Xml.Serialization;

namespace HabboAPI.Furniture
{
    public static class FurnitureEndpoints
    {
        public static async Task<FurniData> GetFurniData(this HabboAPI api)
        {
            var xmlData = await api.GetXml("gamedata/furnidata_xml/0");
            var xmlSerializer = new XmlSerializer(typeof(FurniData));
            using var textReader = xmlData.Root.CreateReader();
            try
            {
                var data = (FurniData)xmlSerializer.Deserialize(textReader);
                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
