using InitialBackend.DataObjects;

namespace InitialBackend.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> List();
        Order? Retrieve(int id);
        int Create(OrderDto orderDto);
    }
}
