using HabboAPI.Badges;
using HabboAPI.Groups;
using HabboAPI.Rooms;

namespace HabboAPI.Users
{
    public class Profile
    {
        public User User { get; set; } = new();
        public List<GroupMembership> Groups { get; set; } = new(0);
        public List<Badge> Badges { get; set; } = new(0);
        public List<Friend> Friends { get; set; } = new(0);
        public List<Room> Rooms { get; set; } = new(0);
    }
}
