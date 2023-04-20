namespace Travel_app_1.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<ProductsType>> GetProducts()
        {
            return Task.FromResult<List<ProductsType>>(new());
        }
    }
}