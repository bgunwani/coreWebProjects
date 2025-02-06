using coreAPIVendorApp.Models;
using coreAPIVendorApp.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;

namespace coreAPIVendorApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productRepository.GetAll();
        }
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productRepository.GetById(id);
            return product == null ? NotFound() : Ok(product);
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _productRepository.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, Product product) 
        {
            if (id != product.Id) return BadRequest();
            _productRepository.Update(product);
            return NoContent();
            // return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
            _productRepository.Delete(id);
            return NoContent();
        }
        [HttpPatch("{id}")]
        public ActionResult PatchProduct(int id, [FromBody] JsonPatchDocument<Product> patchDoc)
        {
            var product = _productRepository.GetById(id);
            if (product == null) return NotFound();

            patchDoc.ApplyTo(product); // Removed ModelState validation

            return NoContent();
        }

    }
}
