using HabboAPI.Utils.Enums;
using NUnit.Framework;

namespace HabboAPI.Tests;

public class BaseApiTests
{
    protected HabboAPI _api = null!;

    [SetUp]
    public void Setup()
    {
        _api = new HabboAPI(Hotel.COM);
    }
}