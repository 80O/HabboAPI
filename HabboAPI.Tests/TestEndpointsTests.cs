using System;
using System.Threading.Tasks;
using HabboAPI.Utils.MiscEndpoints.Info;
using NUnit.Framework;

namespace HabboAPI.Tests;

[TestFixture]
public class TestEndpointsTests : BaseApiTests
{
    [Test]
    public async Task GetTime_NotZero()
    {
        var time = await _api.GetUnixTimestamp();
        Assert.That(time, Is.GreaterThan(DateTime.UnixEpoch));
    }

    [Test]
    public async Task GetHello()
    {
        var message = await _api.GetHello();
        Assert.That(message, Is.EqualTo("hello world"));
    }
}