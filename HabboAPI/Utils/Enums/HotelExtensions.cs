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

    public static string GlobalCode(this Hotel hotel) =>
        @$"hh{hotel switch
        {
            Hotel.COM => "us",
            Hotel.SANDBOX => "s2",
            _ => hotel.ToString().ToLower()
        }}";
}