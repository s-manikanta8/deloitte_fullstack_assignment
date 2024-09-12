using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;
namespace WebApplication5.Repositories

{
    public class ProductRepository : IProductRepository
    {
        public SalesDbContext _context;
        public ProductRepository(SalesDbContext context)
        {
            _context = context;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> Products = _context.Products.ToList();
            return Products;
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Find(id);
        }

        public string AddProduct(Product ProductObj)
        {
            _context.Products.Add(ProductObj);
            _context.SaveChanges();
            return "product is added to the server";
        }
        public string DeleteProduct(int id)
        {
            Product obj = _context.Products.Find(id);

            if (obj != null)
            {
                _context.Products.Remove(obj);
                _context.SaveChanges();
                return "Product details are deleted from server.";
            }
            else
            {
                return "Requested Product details does not exists.";
            }
        }
        public string UpdateProduct(Product obj)
        {
            _context.Products.Update(obj);
            _context.SaveChanges();
            return "Product details updated in server.";
        }
        public List<Product> GetProductbyCategory(string category) {
            var CatProducts = _context.Products.Where(p => p.Category == category).ToList();
            return CatProducts;

        }
        public List<Product> GetOutStock()
        {
            var OutStockProducts = _context.Products.Where(p => p.Quantity == 0).ToList();
            return OutStockProducts;
        }
        public List<Product> GetPriceRangePrdcts(int minprice, int maxprice)
        {
            var InrangeProducts = _context.Products.Where(p => p.UnitPrice > minprice && p.UnitPrice < maxprice).ToList();
            return InrangeProducts;
        }
    }
}
