namespace HabboAPI.Utils;

public abstract class UniqueId
{
    protected UniqueId(string hotelId, string id)
    {
        HotelId = hotelId;
        Id = id;
    }

    protected UniqueId(string uniqueId)
    {
        var dashIndex = uniqueId.IndexOf("-", StringComparison.Ordinal);
        HotelId = uniqueId[..dashIndex];
        Id = uniqueId[(dashIndex + 1)..];
    }

    public string HotelId { get; init; }
    public string Id { get; init; }

    public override string ToString()
    {
        return $"{HotelId}-{Id}";
    }

    public override bool Equals(object? obj)
    {
        return obj != null && obj is UniqueId id && Equals(id);
    }
    public bool Equals(UniqueId obj)
    {
        return obj.GetType() == GetType() && HotelId.Equals(obj.HotelId) && Id.Equals(obj.Id);
    }
}