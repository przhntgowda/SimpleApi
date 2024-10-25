namespace SampleApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        
        public required string Name { get; set; } // Marked as required
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
