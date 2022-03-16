namespace HabboAPI.Achievements;

public class AchievementData
{
    public uint Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateOnly CreationTime { get; set; }
    public string State { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}