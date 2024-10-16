using HabboAPI.Utils.Enums;

namespace HabboAPI.Utils.MiscEndpoints.HotLooks;

public static class HotLooksEndpoints
{
    public static async Task<HotLooks> GetHotLooks(this HabboAPI api)
    {
        var document = await api.GetXml("api/public/lists/hotlooks");
        return new()
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