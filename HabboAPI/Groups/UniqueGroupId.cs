using HabboAPI.Utils;

namespace HabboAPI.Groups;

public class UniqueGroupId : TypedUniqueId
{
    public static UniqueGroupId Empty = new(string.Empty, string.Empty);
    protected override char Prefix => 'g';
    public UniqueGroupId(string hotelId, string id) : base(hotelId, id) { }
    public UniqueGroupId(string uniqueId) : base(uniqueId) { }
}