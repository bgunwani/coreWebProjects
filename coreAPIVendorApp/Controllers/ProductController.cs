using coreAPIVendorApp.Models;
using coreAPIVendorApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreAPIVendorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository = new ProductRepository();

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productRepository.GetAll();
        }
    }
}
