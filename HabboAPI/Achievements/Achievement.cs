using System.Text.Json.Serialization;

namespace HabboAPI.Achievements
{
    public class Achievement
    {
        [JsonPropertyName("achievement")]
        public AchievementData Data { get; set; } = new();

        public List<LevelRequirement> LevelRequirements { get; set; } = new();
    }

    public class AchievementData
    {
        public uint Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateOnly CreationTime { get; set; }
        public string State { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
    }

    public class LevelRequirement
    {
        public uint Level { get; set; }
        public uint RequiredScore { get; set; }
    }

    public class AchievementProgress
    {
        public AchievementData Achievement { get; set; }
        public uint Level { get; set; }
        public uint Score { get; set; }
    }
}
