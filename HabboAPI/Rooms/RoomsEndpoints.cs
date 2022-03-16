namespace HabboAPI.Rooms;

public static class RoomsEndpoints
{
    /// <summary>
    /// Seems to have been removed.
    /// </summary>
    public static Task<List<Room>?> GetPopularRooms(this HabboAPI api) => api.Get<List<Room>>("api/public/rooms/popular");

    /// <summary>
    /// Uses the room id instead of <see cref="UniqueRoomId"/>
    /// </summary>
    public static Task<Room?> GetRoom(this HabboAPI api, uint roomId) => api.Get<Room>($"api/public/rooms/{roomId}");
}