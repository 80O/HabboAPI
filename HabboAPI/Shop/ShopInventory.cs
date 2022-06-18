namespace HabboAPI.Shop;

public class ShopInventory
{
    public ShopCountry Country { get; set; }
    public List<string> PaymentCategories { get; set; }
    public List<PricePoint> PricePoints { get; set; }
    public bool DoubleCredits { get; set; }
}