using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using InitialBackend;
using InitialBackend.DataObjects;
using InitialBackend.Interfaces;
using InitialBackend.Repositories;

namespace InitialBackend.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpPost]
        public ActionResult<int> Create([FromBody] ProductDto productDto)
        {
            var productId = _productRepository.Create(productDto);
            return Ok(productId);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> Retrieve(int id)
        {
            var product = _productRepository.Retrieve(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> List()
        {
            var products = _productRepository.List();
            return Ok(products);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] ProductDto productDto)
        {
            _productRepository.Update(productDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return NoContent();
        }
    }
}
