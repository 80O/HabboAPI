using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;
using HabboAPI.Utils.MiscEndpoints;
using HabboAPI.Utils.MiscEndpoints.HotLooks;

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
}