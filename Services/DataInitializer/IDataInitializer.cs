using Common;

namespace Services.DataInitializer
{
    public interface IDataInitializer : IScopedDependency
    {
        public int Order { get; set; }
        void InitializeData();
    }
}