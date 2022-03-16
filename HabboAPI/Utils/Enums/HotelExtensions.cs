namespace HabboAPI.Utils.Enums;

public static class HotelExtensions
{
    public static string Domain(this Hotel hotel) => hotel switch
    {
        Hotel.SANDBOX => "sandbox.habbo.com",
        Hotel.BR => "www.habbo.com.br",
        Hotel.TR => "www.habbo.com.tr",
        _ => $"www.habbo.{hotel.ToString().ToLower()}"
    };
}