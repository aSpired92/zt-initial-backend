using InitialBackend.DataObjects;

namespace InitialBackend.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> List();
        Product? Retrieve(int id);
        int Create(ProductDto productDto);
        void Update(ProductDto productDto);
        void Delete(int id);
    }
}
