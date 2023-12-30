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
    [Route("api/product-types")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IProductTypeRepository _productTypesRepository;

        public ProductTypeController(IProductTypeRepository productTypesRepository)
        {
            _productTypesRepository = productTypesRepository;
        }

        [HttpPost]
        public ActionResult<int> Create(ProductType productType)
        {
            var productTypeId = _productTypesRepository.Create(productType);
            return Ok(productTypeId);
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductType>> List()
        {
            var products = _productTypesRepository.List();
            return Ok(products);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productTypesRepository.Delete(id);
            return NoContent();
        }
    }
}
