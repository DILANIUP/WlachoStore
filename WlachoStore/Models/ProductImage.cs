namespace WlachoStore.Models
{
    public class ProductImage
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public Product Product { get; set; }
        
    }
}