using WebApplication5.Models;

namespace WebApplication5.Services
{
    public interface IProductServices
    {
        List<Product> GetAllProducts();
        Product GetProductById(int id);
        string AddProduct(Product productObj);
        string DeleteProduct(int id);
        string UpdateProduct(Product productObj);
        public List<Product> GetProductbyCategory(string category);
        public List<Product> GetOutStock();
        public List<Product> GetPriceRangePrdcts(int minprice, int maxprice);
    }
}
