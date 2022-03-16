using HabboAPI.Badges;
using HabboAPI.Rooms;

namespace HabboAPI.Users
{
    public static class UserEndpoints
    {
        public static Task<User?> GetUser(this HabboAPI api, string name) => api.Get<User>($"api/public/users?name={name}");

        public static Task<User?> GetUser(this HabboAPI api, UniqueUserId uuid) => api.Get<User>($"api/public/users/{uuid}");

        public static Task<UniqueUserId> GetUniqueUserId(this HabboAPI api, string name) => api.GetUser(name).ContinueWith((r) => r.Result?.UniqueId ?? UniqueUserId.Empty);

        public static Task<Profile?> GetUserProfile(this HabboAPI api, UniqueUserId uuid)
        {
            if (uuid == UniqueUserId.Empty) return Task.FromResult<Profile?>(null);
            return api.Get<Profile>($"api/public/users/{uuid}/profile");
        }

        public static Task<List<Room>?> GetUserRooms(this HabboAPI api, UniqueUserId uuid) => api.Get<List<Room>>($"api/public/users/{uuid}/rooms");

        public static Task<List<Friend>?> GetUserFriends(this HabboAPI api, UniqueUserId uuid) => api.Get<List<Friend>>($"api/publicusers/{uuid}/friends");

        public static Task<List<Badge>?> GetUserBadges(this HabboAPI api, UniqueUserId uuid) => api.Get<List<Badge>>($"api/public/users/{uuid}/badges");
    }
}
