namespace HabboAPI.Shop;

public class PaymentMethod
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string SmallPrint { get; set; }
    public object ButtonText { get; set; }
    public string Category { get; set; }
    public string ButtonLogoUrl { get; set; }
    public string LocalizationKey { get; set; }
    public bool DisclaimerRequired { get; set; }
    public bool PremiumSms { get; set; }
    public string RequestPath { get; set; }
    public PurchaseParams PurchaseParams { get; set; }
}