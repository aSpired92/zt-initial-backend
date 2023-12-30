using InitialBackend.DataObjects;

namespace InitialBackend.Interfaces
{
    public interface IProductTypeRepository
    {
        IEnumerable<ProductType> List();
        int Create(ProductType productType);
        void Delete(int id);
    }
}
