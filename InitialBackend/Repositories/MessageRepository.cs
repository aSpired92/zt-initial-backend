using InitialBackend.DataObjects;
using InitialBackend.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Drawing;

namespace InitialBackend.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly AppDbContext _context;

        public MessageRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Message> List()
        {
            return _context.Messages.ToList();
        }

        public Message? Retrieve(int id)
        {
            return _context.Messages.Find(id);
        }   

        public int Create(Message message)
        {
            _context.Messages.Add(message);
            _context.SaveChanges();
            return message.Id;
        }

        public void Delete(int id)
        {
            var message = _context.Messages.Find(id);
            if (message != null)
            {
                _context.Messages.Remove(message);
                _context.SaveChanges();
            }
        }
    }
}
