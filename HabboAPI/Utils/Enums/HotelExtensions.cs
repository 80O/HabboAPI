namespace HabboAPI.Utils.Enums;

public static class HotelExtensions
{
    public static string Domain(this Hotel hotel) => hotel switch
    {
        Hotel.SANDBOX => "sandbox.habbo.com",
        Hotel.BR => "habbo.com.br",
        Hotel.TR => "habbo.com.tr",
        Hotel.ORIGINS_COM => "origins.habbo.com",
        Hotel.ORIGINS_BR => "origins.habbo.com.br",
        Hotel.ORIGINS_ES => "origins.habbo.es",
        _ => $"habbo.{hotel.ToString().ToLower()}"
    };

    public static string GlobalCode(this Hotel hotel) =>
        @$"hh{hotel switch
        {
            Hotel.COM => "us",
            Hotel.ORIGINS_COM => "ous",
            Hotel.ORIGINS_ES => "oes",
            Hotel.ORIGINS_BR => "obr",
            Hotel.SANDBOX => "s2",
            _ => hotel.ToString().ToLower()
        }}";

    public static bool IsOrigins(this Hotel hotel) => hotel switch
    {
        Hotel.ORIGINS_COM => true,
        Hotel.ORIGINS_BR => true,
        Hotel.ORIGINS_ES => true,
        _ => false
    };
}