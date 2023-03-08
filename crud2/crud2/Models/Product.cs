namespace crud2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int price { get; set; }
      
        public int CategoryId { get; set; }
        public Category? category { get; set; }
    }
}