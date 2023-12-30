namespace InitialBackend.DataObjects
{
    public class OrderDto
    {
        public required Order Order { get; set; }
        public required OrderElement[] Elements { get; set; }
    }
}
