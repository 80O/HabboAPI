using System.Text.Json.Serialization;
using HabboAPI.Users;

namespace HabboAPI.Utils.MiscEndpoints.Photos;

public class Photo
{
    public string PreviewUrl {get; set; }
    public string[] Tags {get; set; }

    [JsonPropertyName("creator_uniqueId")]
    public UniqueUserId CreatorUniqueId { get; set; }

    public string Type { get; set; }

    public string Url { get; set; }

    public int Version { get; set; }

    public DateTimeOffset Time { get; set; }
    [JsonPropertyName("creator_name")]
    public string CreatorName { get; set; }
    [JsonPropertyName("creator_id")]
    public int CreatorId { get; set; }

    [JsonPropertyName("room_id")]
    public int RoomId { get; set; }
    public Guid Id { get; set; }

    public string[] Likes { get; set; }
}