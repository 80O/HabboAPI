using System;
using System.Linq;
using System.Threading.Tasks;
using HabboAPI.Groups;
using HabboAPI.Rooms;
using HabboAPI.Users;
using NUnit.Framework;

namespace HabboAPI.Tests;

[TestFixture]
public  class GroupsEndpointsTests : BaseApiTests
{
    [Test]
    public async Task GetGroup_ReturnsGroup()
    {
        var groupId = new UniqueGroupId("g-hhus-f1be47c2cf33086c70d1c626feb0e6c9");
        var group = (await _api.GetGroup(groupId))!;

        Assert.That(group, Is.Not.Null);
        Assert.That(group.Id, Is.EqualTo(groupId));
        Assert.That(group.Name, Is.Not.Empty);
        Assert.That(group.RoomId, Is.Not.EqualTo(UniqueRoomId.Empty));
        Assert.That(group.PrimaryColour, Is.Not.Empty);
        Assert.That(group.SecondaryColour, Is.Not.Empty);
    }

    [Test]
    public async Task GetGroupMembers_ReturnsMembers()
    {
        var user = (await _api.GetUser(Constants.Macklebee))!;

        var groupId = new UniqueGroupId("g-hhus-f1be47c2cf33086c70d1c626feb0e6c9");
        var members = (await _api.GetGroupMembers(groupId))!;

        var macklebee = members.FirstOrDefault(m => m.Name.Equals(Constants.Macklebee));
        Assert.That(macklebee, Is.Not.Null);
        Assert.That(macklebee!.UniqueId, Is.EqualTo(user.UniqueId));
        Assert.That(macklebee.HabboFigure, Is.Not.Empty);
        Assert.That(macklebee.MemberSince, Is.GreaterThan(Constants.Year2K));
    }
}