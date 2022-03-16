using HabboAPI.Badges;

namespace HabboAPI.Users;

public class User
{
    public UniqueUserId UniqueId { get; set; } = UniqueUserId.Empty;
    public string Name { get; set; } = string.Empty;
    public string FigureString { get; set; } = string.Empty;
    public string Motto { get; set; } = string.Empty;
    public DateTimeOffset MemberSince { get; set; } = DateTimeOffset.MinValue;
    public bool ProfileVisible { get; set; }
    public List<Badge> SelectedBadges { get; set; } = new(0);

    /// <summary>
    /// Not visible when <see cref="ProfileVisibile"/> is false
    /// </summary>
    public int? CurrentLevel { get; set; }

    /// <summary>
    /// Not visible when <see cref="ProfileVisibile"/> is false
    /// </summary>
    public int? CurrentLevelCompletePercent { get; set; }

    /// <summary>
    /// Not visible when <see cref="ProfileVisibile"/> is false
    /// </summary>
    public int? TotalExperience { get; set; }

    /// <summary>
    /// Not visible when <see cref="ProfileVisibile"/> is false
    /// </summary>
    public int? StarGemCount { get; set; }

    /// <summary>
    /// Not visible when <see cref="ProfileVisibile"/> is false
    /// </summary>
    public bool? Online { get; set; }

    /// <summary>
    /// Not visible when <see cref="ProfileVisibile"/> is false
    /// </summary>
    public DateTimeOffset? LastAccessTime { get; set; }
}