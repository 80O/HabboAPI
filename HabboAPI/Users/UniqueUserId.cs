using HabboAPI.Utils;

namespace HabboAPI.Users;

public class UniqueUserId : UniqueId
{
    public static UniqueUserId Empty = new(string.Empty, string.Empty);
    public UniqueUserId(string hotelId, string id) : base(hotelId, id) { }
    public UniqueUserId(string uniqueId) : base(uniqueId) { }
}