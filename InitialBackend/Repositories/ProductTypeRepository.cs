using InitialBackend.DataObjects;
using InitialBackend.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Drawing;

namespace InitialBackend.Repositories
{
    public class ProductTypeRepository : IProductTypeRepository
    {
        private readonly AppDbContext _context;

        public ProductTypeRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductType> List()
        {
            return _context.ProductTypes.ToList();
        }

        public int Create(ProductType productType)
        {
            _context.ProductTypes.Add(productType);
            _context.SaveChanges();
            return productType.Id;
        }

        public void Delete(int id)
        {
            var productType = _context.ProductTypes.Find(id);
            if (productType != null)
            {
                _context.ProductTypes.Remove(productType);
                _context.SaveChanges();
            }
        }
    }
}
