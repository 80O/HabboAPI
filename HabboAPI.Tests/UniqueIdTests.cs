using HabboAPI.Groups;
using HabboAPI.Rooms;
using HabboAPI.Users;
using NUnit.Framework;

namespace HabboAPI.Tests;

[TestFixture]
public class UniqueIdTests
{
    [Test]
    public void ParseUniqueUserId()
    {
        var hotel = "hhus";
        var id = "bd299448daa60086cd1bc109b7374e19";
        var uuid = new UniqueUserId($"{hotel}-{id}");

        Assert.That(uuid.HotelId, Is.EqualTo(hotel));
        Assert.That(uuid.Id, Is.EqualTo(id));
    }

    [TestCase("hhus-bd299448", "hhus-bd299448", true)]
    [TestCase("hhnl-bd299448", "hhus-bd299448", false)]
    [TestCase("hhus-bd299448A", "hhus-bd299448B", false)]
    [TestCase("hhnl-bd299448A", "hhus-bd299448B", false)]
    public void UniqueUserIdEqual(string idOne, string idTwo, bool equal)
    {
        var uuid = new UniqueUserId(idOne);
        var uuid2 = new UniqueUserId(idTwo);

        Assert.That(uuid.Equals(uuid2), Is.EqualTo(equal));
    }
    [Test]
    public void ParseUniqueGroupId()
    {
        var hotel = "hhus";
        var id = "bd299448daa60086cd1bc109b7374e19";
        var uuid = new UniqueGroupId($"g-{hotel}-{id}");

        Assert.That(uuid.HotelId, Is.EqualTo(hotel));
        Assert.That(uuid.Id, Is.EqualTo(id));
    }

    [TestCase("g-hhus-bd299448", "g-hhus-bd299448", true)]
    [TestCase("g-hhnl-bd299448", "g-hhus-bd299448", false)]
    [TestCase("g-hhus-bd299448A", "g-hhus-bd299448B", false)]
    [TestCase("g-hhnl-bd299448A", "g-hhus-bd299448B", false)]
    public void UniqueGroupIdEqual(string idOne, string idTwo, bool equal)
    {
        var uuid = new UniqueGroupId(idOne);
        var uuid2 = new UniqueGroupId(idTwo);

        Assert.That(uuid.Equals(uuid2), Is.EqualTo(equal));
    }


    [Test]
    public void ParseUniqueRoomId()
    {
        var hotel = "hhus";
        var id = "bd299448daa60086cd1bc109b7374e19";
        var uuid = new UniqueGroupId($"r-{hotel}-{id}");

        Assert.That(uuid.HotelId, Is.EqualTo(hotel));
        Assert.That(uuid.Id, Is.EqualTo(id));
    }

    [TestCase("r-hhus-bd299448", "r-hhus-bd299448", true)]
    [TestCase("r-hhnl-bd299448", "r-hhus-bd299448", false)]
    [TestCase("r-hhus-bd299448A", "r-hhus-bd299448B", false)]
    [TestCase("r-hhnl-bd299448A", "r-hhus-bd299448B", false)]
    public void UniqueRoomIdEqual(string idOne, string idTwo, bool equal)
    {
        var uuid = new UniqueRoomId(idOne);
        var uuid2 = new UniqueRoomId(idTwo);

        Assert.That(uuid.Equals(uuid2), Is.EqualTo(equal));
    }

    [Test]
    public void UniqueIdNotEqualToOtherType()
    {
        var uuidRoom = new UniqueRoomId("r-hhus-bd299448");
        var uuidGroup = new UniqueGroupId("g-hhus-bd299448");
        var uuidUser = new UniqueUserId("hhus-bd299448");

        Assert.False(uuidUser.Equals(uuidGroup));
        Assert.False(uuidUser.Equals(uuidRoom));
        Assert.False(uuidGroup.Equals(uuidRoom));
        Assert.False(uuidGroup.Equals(uuidUser));
        Assert.False(uuidRoom.Equals(uuidUser));
        Assert.False(uuidGroup.Equals(uuidUser));

        Assert.AreNotEqual(uuidUser, uuidGroup);
        Assert.AreNotEqual(uuidUser, uuidRoom);
        Assert.AreNotEqual(uuidGroup, uuidRoom);
        Assert.AreNotEqual(uuidGroup, uuidUser);
        Assert.AreNotEqual(uuidRoom, uuidUser);
        Assert.AreNotEqual(uuidGroup, uuidUser);
    }

}