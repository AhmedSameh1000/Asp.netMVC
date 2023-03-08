using crud2.Models;

namespace crud2.VioModells
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int price { get; set; }
        public byte[] Pooster { get; set; }
        public int CategoryId { get; set; }
        public IEnumerable<Category> categories { get; set; }
    }
}