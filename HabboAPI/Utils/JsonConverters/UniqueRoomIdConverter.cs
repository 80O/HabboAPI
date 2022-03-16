using System.Text.Json;
using System.Text.Json.Serialization;
using HabboAPI.Rooms;

namespace HabboAPI.Utils.JsonConverters;

public class UniqueRoomIdConverter : JsonConverter<UniqueRoomId>
{
    public override UniqueRoomId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new(reader.GetString()!);

    public override void Write(
        Utf8JsonWriter writer,
        UniqueRoomId uniqueId,
        JsonSerializerOptions options) =>
        writer.WriteStringValue(uniqueId.ToString());
}