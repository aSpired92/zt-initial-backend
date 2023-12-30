namespace InitialBackend.DataObjects
{
    public class ProductDto
    {
        public required Product Product { get; set; }
        public required byte[] Image { get; set; }
    }
}
