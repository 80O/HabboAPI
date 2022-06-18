using HabboAPI.Shop;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace HabboAPI.Tests;

[TestFixture]
public class ShopEndpointsTests : BaseApiTests
{

    [Test]
    public async Task GetCountries()
    {
        var countries = await _api.GetShopCountries();
        Assert.That(countries!.Any(c => c.CountryCode.Equals("all")));
    }

    [Test]
    public async Task GetInventory()
    {
        var inventory = await _api.GetShopInventory("us");
        Assert.That(inventory.Country.CountryCode, Is.EqualTo("us"));
        Assert.That(inventory.PaymentCategories, Is.Not.Empty);
        Assert.That(inventory.PricePoints, Is.Not.Empty);
    }
}