namespace HabboAPI.Utils.MiscEndpoints.Leaderboards;

public static class LeaderBoardEndpoints
{
    public static Task<List<RoomVisitsLeaderboardEntry>> GetRoomVisitsLeaderBoard(this HabboAPI api)
        => api.GetFromUrl<List<RoomVisitsLeaderboardEntry>>("https://images.habbo.com/habbo-web-leaderboards//%GLOBAL%/visited-rooms/daily/latest.json", "%GLOBAL%");
}