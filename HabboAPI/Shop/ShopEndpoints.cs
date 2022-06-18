namespace HabboAPI.Shop
{
    public static class ShopEndpoints
    {

        // shopapi/public/countries
        /// <summary>
        /// Get all available countries for the shop
        /// </summary>
        public static Task<List<ShopCountry>?> GetShopCountries(this HabboAPI api) => api.Get<List<ShopCountry>>("shopapi/public/countries");

        public static Task<ShopInventory?> GetShopInventory(this HabboAPI api, string countryCode) => api.Get<ShopInventory>($"shopapi/public/inventory/{countryCode}");
    }
}
