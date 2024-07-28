namespace HabboAPI.Marketplace;

public static class MarketplaceEndpoints
{
    public static Task<Marketplace?> GetMarketplaceFloorItem(this HabboAPI api, string className) => 
        api.Get<Marketplace>($"api/public/marketplace/stats/roomItem/{className}");

    public static Task<Marketplace?> GetMarketplaceWallItem(this HabboAPI api, string className) =>
        api.Get<Marketplace>($"api/public/marketplace/stats/roomItem/{className}");
}