using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using HabboAPI.Furniture;
using HabboAPI.Users;
using HabboAPI.Utils.MiscEndpoints.HotLooks;
using HabboAPI.Utils.MiscEndpoints.Leaderboards;
using HabboAPI.Utils.MiscEndpoints.Photos;

namespace HabboAPI.Tests;

[TestFixture]
public class MiscEndpointsTests : BaseApiTests
{

    [Test]
    public async Task GetHotLooks()
    {
        var looks = await _api.GetHotLooks();
        Assert.That(looks.Looks.Count, Is.EqualTo(10));
        Assert.That(looks.Looks.All(l => !string.IsNullOrWhiteSpace(l.Figure) && !string.IsNullOrWhiteSpace(l.Hash)));
    }

    [Test]
    public async Task GetFurniture()
    {
        var data = await _api.GetFurniData();
        Assert.That(data, Is.Not.Null);
        Assert.That(data.FloorItems, Is.Not.Empty);
        Assert.That(data.FloorItems.Any(f => f.ClassName.Equals("throne")));
        Assert.That(data.WallItems, Is.Not.Empty);
    }

    [Test]
    public async Task GetRoomVisitsLeaderboard()
    {
        var data = await _api.GetRoomVisitsLeaderBoard();
        Assert.That(data, Is.Not.Null);
    }

    [Test]
    public async Task GetPhotos()
    {
        var data = await _api.GetPhotos();
        Assert.That(data, Is.Not.Null);
    }

    [Test]
    public async Task GetUserPhotos()
    {
        var user = await _api.GetUser("Macklebee");
        var data = await _api.GetUserPhotos(user.UniqueId);
        Assert.That(data, Is.Not.Null);
    }
}