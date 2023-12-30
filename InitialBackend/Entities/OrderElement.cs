namespace InitialBackend
{
    public class OrderElement
    {
        public int Id { get; private set; }
        public required Order Order { get; set; }
        public required Product Product { get; set; }
        public required int Quantity { get; set; }
    }
}
