namespace mvc_crud.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? name { get; set; }
        public IEnumerable<Product>? products { get; set; }
    }
}