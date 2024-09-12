using WebApplication5.Models;
using WebApplication5.Repositories;
namespace WebApplication5.Services

{
    public class ProductServices : IProductServices
    {
        public IProductRepository _repository;
        public ProductServices(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public string AddProduct(Product ProductObj)
        {
            return _repository.AddProduct(ProductObj);
        }
        public string DeleteProduct(int id)
        {
            return _repository.DeleteProduct(id);
        }
        public string UpdateProduct(Product ProductObj)
        {
            return _repository.UpdateProduct(ProductObj);
        }
        public List<Product> GetProductbyCategory(string category)
        {
            return _repository.GetProductbyCategory(category);
        }
        public List<Product> GetOutStock()
        {
            return _repository.GetOutStock();
        }
        public List<Product> GetPriceRangePrdcts(int minprice, int maxprice)
        {
            return _repository.GetPriceRangePrdcts(minprice, maxprice);
        }
    }
}
