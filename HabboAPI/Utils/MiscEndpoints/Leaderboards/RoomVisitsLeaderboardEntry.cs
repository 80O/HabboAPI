using HabboAPI.Rooms;

namespace HabboAPI.Utils.MiscEndpoints.Leaderboards
{
    public class RoomVisitsLeaderboardEntry : Room
    {
        public uint LeaderBoardRank { get; set; }
        public string LeaderBoardValue { get; set; }
    }
}
