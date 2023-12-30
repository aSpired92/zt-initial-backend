namespace InitialBackend
{
    public class Message : TimeTrackedEntity
    {
        public int Id { get; private set; }
        public required string Author { get; set; }
        public required string Email { get; set; }
        public required string Content { get; set; }
    }
}
