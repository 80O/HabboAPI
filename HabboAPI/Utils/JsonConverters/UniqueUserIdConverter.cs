using System.Text.Json;
using System.Text.Json.Serialization;
using HabboAPI.Users;

namespace HabboAPI.Utils.JsonConverters;

public class UniqueUserIdConverter : JsonConverter<UniqueUserId>
{
    public override UniqueUserId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new(reader.GetString()!);

    public override void Write(
        Utf8JsonWriter writer,
        UniqueUserId uniqueId,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(uniqueId.ToString());
}