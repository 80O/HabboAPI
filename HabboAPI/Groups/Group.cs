using HabboAPI.Rooms;

namespace HabboAPI.Groups
{
    public class Group
    {
        public UniqueGroupId Id { get; set; } = UniqueGroupId.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public GroupType Type { get; set; } = GroupType.Normal;
        public UniqueRoomId RoomId { get; set; } = UniqueRoomId.Empty;
        public string BadgeCode { get; set; } = string.Empty;
        public string PrimaryColour { get; set; } = string.Empty;
        public string SecondaryColour { get; set; } = string.Empty;
        public bool Online { get; set; }
        public bool IsAdmin { get; set; }
    }

    public enum GroupType
    {
        Normal,
        Exclusive,
        Closed,
    }
}
