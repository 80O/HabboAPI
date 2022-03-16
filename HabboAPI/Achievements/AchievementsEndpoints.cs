using HabboAPI.Users;

namespace HabboAPI.Achievements;

public static class AchievementsEndpoints
{
    public static Task<List<Achievement>?> GetAchievements(this HabboAPI api) => api.Get<List<Achievement>>("api/public/achievements");

    public static Task<List<AchievementProgress>?> GetUserAchievements(this HabboAPI api, UniqueUserId uuid) =>
        api.Get<List<AchievementProgress>>($"api/public/achievements/{uuid}");
}