using Entities.Product;

namespace Services.Category.ViewModels
{
    //public class VehicleFilteVM : BaseDto<VehicleFilteVM, Vehicle>
    //{
    //    public VehicleType Type { get; set; }
    //    public VehicleTip Tip { get; set; }
    //    public VehicleModel Model { get; set; }
    //    public VehicleBrand Brand { get; set; }
    //    public VehicleYear Year { get; set; }
    //    public string Name { get; set; }
    //}

    public class VehicleFilter2VM
    {

        public int VehicleBrandsId { get; set; }
        public string VehicleBrandsName { get; set; }
        public string VehiclePersianName { get; set; }
        public string VehicleBrandImagePath { get; set; }

        public int VehicleYearsId { get; set; }
        public string VehicleYearsName { get; set; }

        public int VehicleTypesId { get; set; }
        public string VehicleTypesName { get; set; }

        public int VehicleTipsId { get; set; }
        public string VehicleTipsName { get; set; }

        public int VehicleModelsId { get; set; }
        public string VehicleModelsName { get; set; }

        public int VehiclesId { get; set; }
        public string VehiclesName { get; set; }
        public string ImagePath { get; set; }
    }


}
