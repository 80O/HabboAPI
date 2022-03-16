using HabboAPI.Achievements;
using NUnit.Framework;
using System;
using System.Linq;
using System.Threading.Tasks;
using HabboAPI.Users;

namespace HabboAPI.Tests;

[TestFixture]
public class AchievementEndpointsTests : BaseApiTests
{
    [Test]
    public async Task GetAchievements_ReturnsListOfAchievements()
    {
        var achievements = await _api.GetAchievements();

        Assert.That(achievements, Is.Not.Empty);
    }

    [Test]
    public async Task GetAchievements_CorrectlyConverted()
    {
        var achievements = await _api.GetAchievements();
        var loginAchievement = achievements!.FirstOrDefault(ach => ach.Data.Name.Equals("Login", StringComparison.OrdinalIgnoreCase))!;

        Assert.That(loginAchievement, Is.Not.Null);
        Assert.That(loginAchievement.Data.CreationTime, Is.GreaterThan(DateOnly.FromDateTime(Constants.Year2K.UtcDateTime)));
        Assert.That(loginAchievement.Data.Category, Is.Not.Empty);
        Assert.That(loginAchievement.Data.Id, Is.Not.Zero);
        Assert.That(loginAchievement.LevelRequirements, Is.Not.Empty);
        Assert.That(loginAchievement.LevelRequirements.First().Level, Is.EqualTo(1));
        Assert.That(loginAchievement.LevelRequirements.First().RequiredScore, Is.GreaterThan(0));
    }

    [Test]
    public async Task GetUserAchievements()
    {
        var achievements = await _api.GetUserAchievements(await _api.GetUniqueUserId(Constants.Macklebee));

        Assert.That(achievements, Is.Not.Empty);
    }
}