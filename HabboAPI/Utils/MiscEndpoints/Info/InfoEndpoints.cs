using System.Text.Json;

namespace HabboAPI.Utils.MiscEndpoints.Info;

public static partial class InfoEndpoints
{
    public static async Task<string> GetHello(this HabboAPI api)
    {
        var result = await api.Get<JsonElement>("api/public/info/hello");
        return result.GetProperty("message").GetString() ?? throw new InvalidDataException("Unexpected reply status");
    }

    public static async Task<DateTime> GetUnixTimestamp(this HabboAPI api)
    {
        var result = await api.Get<JsonElement>("api/public/info/time");
        return DateTime.UnixEpoch + TimeSpan.FromMilliseconds(result.GetProperty("time").GetUInt64());
    }
}