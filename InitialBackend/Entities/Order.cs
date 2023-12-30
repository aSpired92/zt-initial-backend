namespace InitialBackend
{
    public class Order : TimeTrackedEntity
    {
        public int Id { get; private set; }
        public required string Fullname { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public required string Address { get; set; }
        public required OrderElement[] Elements { get; set; }
    }
}
