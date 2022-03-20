using HabboAPI.Users;

namespace HabboAPI.Achievements;

public static class AchievementsEndpoints
{
    public static Task<List<Achievement>?> GetAchievements(this HabboAPI api) => api.Get<List<Achievement>>("api/public/achievements");

    public static Task<IEnumerable<string>> GetAchievementsCategories(this HabboAPI api) => api.GetAchievements().ContinueWith(t => t.Result?.Select(a => a.Data.Category).Distinct() ?? Enumerable.Empty<string>());

    public static Task<Dictionary<string, List<Achievement>>> GetAchievementsGroupedByCategory(this HabboAPI api) => api.GetAchievements().ContinueWith(t => t.Result?.GroupBy(ach => ach.Data.Category).ToDictionary(g => g.Key, g => g.ToList()) ?? new());

    public static Task<List<AchievementProgress>?> GetUserAchievements(this HabboAPI api, UniqueUserId uuid) =>
        api.Get<List<AchievementProgress>>($"api/public/achievements/{uuid}");
}