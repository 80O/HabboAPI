using System.Text.Json;
using System.Text.Json.Serialization;
using HabboAPI.Groups;

namespace HabboAPI.Utils.JsonConverters;

public class UniqueGroupIdConverter : JsonConverter<UniqueGroupId>
{
    public override UniqueGroupId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new(reader.GetString()!);

    public override void Write(
        Utf8JsonWriter writer,
        UniqueGroupId uniqueId,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(uniqueId.ToString());
}