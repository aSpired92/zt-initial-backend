using InitialBackend.DataObjects;
using InitialBackend.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Drawing;

namespace InitialBackend.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> List()
        {
            return _context.Orders.ToList();
        }

        public Order? Retrieve(int id)
        {
            return _context.Orders.Find(id);
        }

        public int Create(OrderDto orderDto)
        {
            _context.Orders.Add(orderDto.Order);
            foreach (OrderElement element in orderDto.Elements)
            {
                _context.OrderElements.Add(new OrderElement { Order = element.Order, Product = element.Product, Quantity = element.Quantity });
            }
            _context.SaveChanges();
            return orderDto.Order.Id;
        }
    }
}
