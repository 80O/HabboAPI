using HabboAPI.Utils;

namespace HabboAPI.Rooms;

public class UniqueRoomId : TypedUniqueId
{
    public static UniqueRoomId Empty = new(string.Empty, string.Empty);
    protected override char Prefix => 'r';
    public UniqueRoomId(string hotelId, string id) : base(hotelId, id) { }
    public UniqueRoomId(string uniqueId) : base(uniqueId) { }
}