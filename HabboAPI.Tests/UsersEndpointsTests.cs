using System.Threading.Tasks;
using HabboAPI.Users;
using NUnit.Framework;

namespace HabboAPI.Tests;

/// These tests are using the official APIs.
/// Feel free to create unit tests that use mocked data
/// to verify everything gets added correctly.
public class UsersEndpointsTests : BaseApiTests
{

    [Test]
    public async Task GetUserByName_ReturnsUser()
    {
        var user = (await _api.GetUser(Constants.Macklebee))!;
        AssertIsMacklebee(user);
    }

    [Test]
    public async Task GetUserByUniqueId_ReturnsUser()
    {
        var user = (await _api.GetUser(Constants.Macklebee))!;
        Assert.That(user, Is.Not.Null);
        Assert.That(user.UniqueId, Is.Not.EqualTo(UniqueUserId.Empty));
        var userViaUniqueId = (await _api.GetUser(user.UniqueId))!;
        Assert.That(userViaUniqueId.Name, Is.EqualTo(Constants.Macklebee));
    }

    [Test]
    public async Task GetUserProfile()
    {
        var profile = (await _api.GetUserProfile(await _api.GetUniqueUserId(Constants.Macklebee)))!;

        Assert.That(profile.User, Is.Not.Null);
        AssertIsMacklebee(profile.User);
        Assert.That(profile.Groups, Is.Not.Empty);
        Assert.That(profile.Badges, Is.Not.Empty);
        Assert.That(profile.Friends, Is.Not.Empty);
        Assert.That(profile.Rooms, Is.Not.Empty);
    }

    public void AssertIsMacklebee(User user)
    {
        Assert.That(user.Name, Is.EqualTo(Constants.Macklebee));
        Assert.That(user.MemberSince, Is.GreaterThan(Constants.Year2K));
        Assert.That(user.LastAccessTime, Is.GreaterThan(Constants.Year2K));
        Assert.That(user.SelectedBadges, Is.Not.Empty);
    }
}