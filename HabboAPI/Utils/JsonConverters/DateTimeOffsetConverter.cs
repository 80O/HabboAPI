using System.Text.Json;
using System.Text.Json.Serialization;

namespace HabboAPI.Utils.JsonConverters;

public class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
{
    public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        try
        {
            if (reader.TryGetInt64(out var millis))
                return new(DateTime.UnixEpoch.AddMilliseconds(millis));
        }
        catch (Exception _) { }

        var value = reader.GetString();
        if(value == null) return DateTimeOffset.MinValue;
        return DateTimeOffset.Parse(value);
    }

    public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}