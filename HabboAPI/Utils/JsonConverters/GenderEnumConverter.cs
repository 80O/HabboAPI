using HabboAPI.Utils.Enums;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HabboAPI.Utils.JsonConverters;

public class GenderEnumConverter : JsonConverter<Gender>
{
    public override Gender Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var value = reader.GetString()!;
        if (string.Equals(value, "m", StringComparison.OrdinalIgnoreCase) ||
            value.Equals("male", StringComparison.OrdinalIgnoreCase))
            return Gender.Male;
        return Gender.Female;
    }

    public override void Write(Utf8JsonWriter writer, Gender value, JsonSerializerOptions options) => writer.WriteStringValue(value == Gender.Male ? "m" : "f");
}