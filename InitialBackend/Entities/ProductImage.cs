namespace InitialBackend
{
    public class ProductImage
    {
        public int Id { get; private set; }
        public required byte[] Image { get; set; }

        public required Product Product { get; set; }
    }
}
