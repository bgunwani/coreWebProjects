using coreAPIVendorApp.Models;

namespace coreAPIVendorApp.Repositories
{
    public interface IProductRepository
    {
        public List<Product> GetAll();
        public Product? GetById(int id);
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(int id);
        public void PatchProduct(int id, decimal? price, string? name);
    }
}
