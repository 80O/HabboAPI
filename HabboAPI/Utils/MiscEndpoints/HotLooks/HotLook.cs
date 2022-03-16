using HabboAPI.Utils.Enums;

namespace HabboAPI.Utils.MiscEndpoints.HotLooks;

public class HotLook
{
    public Gender Gender { get; set; } = Gender.Male;
    public string Figure { get; set; } = string.Empty;
    public string Hash { get; set; } = string.Empty;
}