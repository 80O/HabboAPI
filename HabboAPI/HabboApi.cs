using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using HabboAPI.Utils.Enums;
using HabboAPI.Utils.JsonConverters;

namespace HabboAPI;

public class HabboAPI
{
    public Hotel Hotel { get; }
    private HttpClient HttpClient { get; }
    private readonly JsonSerializerOptions _jsonSerializerOptions = new()
    {
        WriteIndented = true,
        Converters =
        {
            new UniqueUserIdConverter(),
            new UniqueGroupIdConverter(),
            new UniqueRoomIdConverter(),
            new DateOnlyConverter(),
            new DateTimeOffsetConverter(),
            new GroupTypeEnumConverter(),
            new DoorModeEnumConverter(),
            new GenderEnumConverter()
        },
        PropertyNameCaseInsensitive = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.AllowNamedFloatingPointLiterals
    };

    public HabboAPI(Hotel hotel)
    {
        Hotel = hotel;
        HttpClient = new();
        HttpClient.DefaultRequestHeaders.UserAgent.Add(new("HabboAPI", "v1"));
    }

    public Task<T?> Get<T>(string endpoint) => HttpClient.GetFromJsonAsync<T>($"https://{Hotel.Domain()}/{endpoint.TrimStart('/')}", _jsonSerializerOptions);

    public Task<T?> GetFromUrl<T>(string url, string? globalCodeParameter = null, string? domainParameter = null)
    {
        if (globalCodeParameter != null)
            url = url.Replace(globalCodeParameter, Hotel.GlobalCode());
        if (domainParameter != null)
            url = url.Replace(domainParameter, Hotel.Domain());

        return HttpClient.GetFromJsonAsync<T>(url, _jsonSerializerOptions);
    }

    public async Task<XDocument> GetXml(string endpoint)
    {
        var reply = await HttpClient.GetStringAsync($"https://{Hotel.Domain()}/{endpoint.TrimStart('/')}");
        return XDocument.Parse(reply);
    }
}