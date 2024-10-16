using System.Threading.Tasks;
using HabboAPI.Users;
using HabboAPI.Utils.Enums;
using NUnit.Framework;

namespace HabboAPI.Tests;

public class BaseApiTests
{
    protected HabboAPI _api = null!;
    private UniqueUserId _uuid;

    [SetUp]
    public async Task Setup()
    {
        _api = new(Hotel.COM);
        _uuid = await _api.GetUniqueUserId(Constants.Macklebee);
    }
}