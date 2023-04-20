namespace Travel_app_1.Northwind
{
    public interface INorthwindService
    {
        Task<List<ProductsType>> GetProducts();
    }
}