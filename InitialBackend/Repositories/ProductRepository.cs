using InitialBackend.DataObjects;
using InitialBackend.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Drawing;

namespace InitialBackend.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> List()
        {
            return _context.Products.ToList();
        }

        public Product? Retrieve(int id)
        {
            return _context.Products.Find(id);
        }

        public int Create(ProductDto productDto)
        {
            _context.Products.Add(productDto.Product);
            _context.ProductImages.Add(new ProductImage{ Image = productDto.Image, Product = productDto.Product });
            _context.SaveChanges();
            return productDto.Product.Id;
        }

        public void Update(ProductDto productDto)
        {
            _context.Entry(productDto.Product).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
        }
    }
}
