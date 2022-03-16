namespace HabboAPI.Groups
{
    public static class GroupsEndpoints
    {
        public static Task<Group?> GetGroup(this HabboAPI api, UniqueGroupId uuid) => api.Get<Group>($"api/public/groups/{uuid}");

        public static Task<List<GroupMember>?> GetGroupMembers(this HabboAPI api, UniqueGroupId uuid, int pageIndex = 0) =>
            api.Get<List<GroupMember>>($"api/public/groups/{uuid}/members?pageIndex={pageIndex}");
    }
}
