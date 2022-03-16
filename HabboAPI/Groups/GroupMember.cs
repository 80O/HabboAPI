using HabboAPI.Users;
using HabboAPI.Utils;
using HabboAPI.Utils.MiscEndpoints;

namespace HabboAPI.Groups
{
    public class GroupMember
    {
        public Gender Gender { get; set; }
        public string Motto { get; set; }
        public string HabboFigure { get; set; }
        public DateTimeOffset MemberSince { get; set; }
        public UniqueUserId UniqueId { get; set; }
        public string Name { get; set; }
        public bool Online { get; set; }
        public bool IsAdmin { get; set; }
    }
}
