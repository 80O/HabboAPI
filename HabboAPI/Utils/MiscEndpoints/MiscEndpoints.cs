namespace HabboAPI.Utils.MiscEndpoints
{
    public static class MiscEndpoints
    {
        public static async Task<HotLooks> GetHotLooks(this HabboAPI api)
        {
            var document = await api.GetXml("api/public/lists/hotlooks");
            return new HotLooks()
            {
                ImagerUrl = document.Root!.Attribute("url")!.Value,
                Looks = document.Root.Elements().Where(e => e.Name.LocalName.Equals("habbo")).Select(e => new HotLook
                {
                    Gender = e.Attribute("gender")!.Value == "f" ? Gender.Female : Gender.Male,
                    Figure = e.Attribute("figure")!.Value,
                    Hash = e.Attribute("hash")!.Value
                }).ToList()
            };
        }
    }

    public class HotLooks
    {
        public string ImagerUrl { get; set; } = string.Empty;
        public List<HotLook> Looks { get; set; } = new(0);
    }

    public class HotLook
    {
        public Gender Gender { get; set; } = Gender.Male;
        public string Figure { get; set; } = string.Empty;
        public string Hash { get; set; } = string.Empty;
    }

    public enum Gender
    {
        Male,
        Female
    }
}
