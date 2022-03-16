namespace HabboAPI.Utils;

public abstract class TypedUniqueId : UniqueId
{
    protected abstract char Prefix { get; }

    protected TypedUniqueId(string hotelId, string id) : base(hotelId, id)
    {
    }

    protected TypedUniqueId(string uniqueId) : base(uniqueId[(uniqueId.IndexOf('-') + 1)..])
    {
    }
    public override string ToString()
    {
        return $"{Prefix}-{HotelId}-{Id}";
    }

    public override bool Equals(object? obj)
    {
        return obj is TypedUniqueId id && Equals(id);
    }

    public bool Equals(TypedUniqueId obj)
    {
        return Prefix.Equals(obj.Prefix) && base.Equals(obj);
    }
}