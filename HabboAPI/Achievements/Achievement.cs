using System.Text.Json.Serialization;

namespace HabboAPI.Achievements;

public class Achievement
{
    [JsonPropertyName("achievement")]
    public AchievementData Data { get; set; } = new();

    public List<LevelRequirement> LevelRequirements { get; set; } = new();
}