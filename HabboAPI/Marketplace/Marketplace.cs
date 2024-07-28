namespace HabboAPI.Marketplace;

public class Marketplace
{
    public History[] History { get; set; }
    public string StatsDate { get; set; }
    public int SoldItemCount { get; set; }
    public int CreditSum { get; set; }
    public int AveragePrice { get; set; }
    public int TotalOpenOffers { get; set; }
    public int HistoryLimitInDays { get; set; }
}