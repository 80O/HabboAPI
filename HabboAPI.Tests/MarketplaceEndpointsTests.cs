using System.Threading.Tasks;
using HabboAPI.Marketplace;
using NUnit.Framework;

namespace HabboAPI.Tests;

[TestFixture]
public class MarketplaceEndpointsTests : BaseApiTests
{
    [Test]
    public async Task GetRoomItem()
    {
        var marketplace = await _api.GetMarketplaceFloorItem("throne");

        Assert.That(marketplace, Is.Not.Null);
        Assert.That(marketplace.History, Is.Not.Empty);
        Assert.That(marketplace.HistoryLimitInDays, Is.EqualTo(30));
    }
}