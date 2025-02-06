using coreAPIVendorApp.Data;
using coreAPIVendorApp.Models;

namespace coreAPIVendorApp.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product? product = _context.Products.FirstOrDefault(x => x.Id == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }

        public List<Product> GetAll() => _context.Products.ToList();

        public Product? GetById(int id) => _context.Products.FirstOrDefault(x => x.Id == id);

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }

        public void PatchProduct(int id, decimal? price, string? name)
        {
            var existingProduct = _context.Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct != null)
            {
                if(price.HasValue) existingProduct.Price = price.Value;
                if(!string.IsNullOrEmpty(name)) existingProduct.Name = name;
            }
        }
    }
}
