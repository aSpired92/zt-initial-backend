using InitialBackend.DataObjects;

namespace InitialBackend.Interfaces
{
    public interface IMessageRepository
    {
        IEnumerable<Message> List();
        Message? Retrieve(int id);
        int Create(Message message);
        void Delete(int id);
    }
}
