namespace Entities
{
    public struct DatabaseStoreProcedure
    {
        public static string GetCategoryParentPartsProducts => "getCategoryParentPartsProducts";
        public static string GetCategoryParentForHome => "getCategoryParentForHome";
        public static string GetCart => "GetCart";
        public static string GetOrder => "GetOrder";
        public static string GetOrdersOfUsers => "GetOrdersOfUsers";
        public static string SyncSales => "sync.spSyncAllDatasSale";
        public static string SyncManualSales => "sync.spSyncManualSale";
        public static string SyncAllData => "sync.spSyncAllDatas";
        public static string SyncProductInfos => "sync.spSyncProductInfos";
        public static string GetEditProductInfoMainPageData => "product.sp_GetEditProductInfoMainPageData";
        public static string GetProductMainInfo => "product.sp_GetProductMainInfo";
        public static string GetPartOfProduct => "sp_GetPartOfProduct";
        public static string GetInquiryProduct => "sp_GetInquiryProduct";
        public static string GetCustomers => "sp_GetCustomers";
        public static string SyncDataCustomer => "sync.spSyncAllDatasCustomer";
    }
}