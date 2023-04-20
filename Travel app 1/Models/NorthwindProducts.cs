//namespace Travel_app_1.Data.Northwind; // Razor won't recognize third level namespace
namespace Travel_app_1.Northwind;

public class ProductsType
{
    public double ProductID { get; set; }
    public double SupplierID { get; set; }
    public double CategoryID { get; set; }
    public string QuantityPerUnit { get; set; }
    public double UnitPrice { get; set; }
    public double UnitsInStock { get; set; }
    public double UnitsOnOrder { get; set; }
    public double ReorderLevel { get; set; }
    public bool Discontinued { get; set; }
    public string Name { get; set; }
}
