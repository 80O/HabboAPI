using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HabboAPI.Utils.JsonConverters;

public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Debug.Assert(typeToConvert == typeof(DateTimeOffset));
        if (reader.TryGetInt64(out var millis))
            return new DateTimeOffset(DateTime.UnixEpoch.AddMilliseconds(millis));

        return DateTimeOffset.Parse(reader.GetString()!);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}