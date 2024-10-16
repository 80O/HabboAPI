using System.Xml.Serialization;

namespace HabboAPI.Furniture
{
    public static class FurnitureEndpoints
    {
        public static async Task<FurniData> GetFurniData(this HabboAPI api)
        {
            try
            {
                var xmlData = await api.GetXml("gamedata/furnidata_xml/0");
            var xmlSerializer = new XmlSerializer(typeof(FurniData));
            using var reader = xmlData.Root.CreateReader();
            var data = (FurniData)xmlSerializer.Deserialize(reader);
                return data;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
