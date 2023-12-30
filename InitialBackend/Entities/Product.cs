namespace InitialBackend
{
    public class Product
    {
        public int Id { get; private set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }

        public required ProductType ProductType { get; set; }


        public int ProductImageId { get; set; }
        public ProductImage? ProductImage { get; set; }
    }
}
