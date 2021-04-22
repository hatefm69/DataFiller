namespace Entities
{
    public struct DatabaseViews
    {
        public static string GetFilters { get; } = "SELECT * FROM GetFilters";
        public static string GetParentCategories { get; } = "SELECT * FROM GetParentCategories";
        public static string GetCategoryParentPartsProductsVM { get; } = "SELECT * FROM GetCategoryParentPartsProductsVM";
        public static string GetCategoryParentPartsProductsOnlyProductVM { get; } = "SELECT ProductsId FROM GetCategoryParentPartsProductsVM";
        public static string GetQuickSearchPart { get; set; } = "SELECT * FROM SearchPartVM WHERE 1 = 1";
        public static string GetQuickSearchCategory { get; } = "SELECT * FROM SearchCategoryVM WHERE 1 = 1";
        public static string GetVehicles { get; } = "SELECT v.Id, v.Name, v.PersianName, v.KeyWordId FROM VehiclesVw v";
        public static string GetBrands { get; } = "SELECT b.Id, b.Name FROM product.Brands b";
        public static string GetCountries { get; } = "SELECT c.Id, c.Name FROM product.Countries c";
        public static string GetUnits { get; } = "SELECT u.Id, u.Name FROM product.Units u";
    }
}