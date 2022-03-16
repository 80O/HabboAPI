namespace HabboAPI.Users;

public class Friend
{
    public string Name { get; set; } = string.Empty;
    public string Motto { get; set; } = string.Empty;
    public bool Online { get; set; }
    public UniqueUserId UniqueId { get; set; } = UniqueUserId.Empty;
    public string FigureString { get; set; } = string.Empty;
}