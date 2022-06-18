namespace HabboAPI.Shop;

public class PricePoint
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CreditAmount { get; set; }
    public string Price { get; set; }
    public int IconId { get; set; }
    public List<string> Categories { get; set; }
    public string CountryCode { get; set; }
    public List<PaymentMethod> PaymentMethods { get; set; }
    public List<SubProduct> SubProducts { get; set; }
    public bool? DoubleCredits { get; set; }
}