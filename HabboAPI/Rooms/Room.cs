using HabboAPI.Users;

namespace HabboAPI.Rooms;

public class Room
{
    public uint Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTimeOffset CreationTime { get; set; }
    public List<string> Tags { get; set; } = new(0);
    public uint MaximumVisitors { get; set; }
    public bool ShowOwnerName { get; set; }
    public string OwnerName { get; set; } = string.Empty;
    public UniqueUserId OwnerUniqueId { get; set; } = UniqueUserId.Empty;
    public List<string> Categories { get; set; } = new(0);
    public string ImageUrl { get; set; } = string.Empty;
    public int Rating { get; set; }
    public string ThumbnailUrl { get; set; } = string.Empty;

    /// <summary>
    /// Note: Information not available when requesting rooms through profile!
    /// </summary>
    public bool PublicRoom { get; set; }
    /// <summary>
    /// Note: Information not available when requesting rooms through profile!
    /// </summary>
    public DoorMode DoorMode { get; set; }
    /// <summary>
    /// Note: Information not available when requesting rooms through profile!
    /// </summary>
    public string UniqueId { get; set; } = string.Empty;
}