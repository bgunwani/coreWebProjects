using coreAPIVendorApp.Models;

namespace coreAPIVendorApp.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private static List<Product> _products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200},
            new Product { Id = 2, Name = "Phone", Price = 2200},
            new Product { Id = 3, Name = "Keyboard", Price = 1000},
        };

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(x => x.Id == id);

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
