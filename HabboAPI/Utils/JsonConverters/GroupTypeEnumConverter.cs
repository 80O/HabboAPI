using HabboAPI.Groups;
using HabboAPI.Rooms;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using HabboAPI.Utils.Enums;

namespace HabboAPI.Utils.JsonConverters;

public class GroupTypeEnumConverter : JsonConverter<GroupType>
{
    public override GroupType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Debug.Assert(typeToConvert == typeof(GroupType));
        Enum.TryParse<GroupType>(reader.GetString()!.ToLower(), true, out var enumValue);
        return enumValue;
    }

    public override void Write(Utf8JsonWriter writer, GroupType value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString().ToUpper());
    }
}
public class DoorModeEnumConverter : JsonConverter<DoorMode>
{
    public override DoorMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Debug.Assert(typeToConvert == typeof(DoorMode));
        Enum.TryParse<DoorMode>(reader.GetString()!.ToLower(), true, out var enumValue);
        return enumValue;
    }

    public override void Write(Utf8JsonWriter writer, DoorMode value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString().ToLower());
    }
}
public class GenderEnumConverter : JsonConverter<Gender>
{
    public override Gender Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        Debug.Assert(typeToConvert == typeof(Gender));
        var value = reader.GetString()!;
        if (string.Equals(value, "m", StringComparison.OrdinalIgnoreCase) ||
            value.Equals("male", StringComparison.OrdinalIgnoreCase))
            return Gender.Male;
        return Gender.Female;
    }

    public override void Write(Utf8JsonWriter writer, Gender value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value == Gender.Male ? "m" : "f");
    }
}