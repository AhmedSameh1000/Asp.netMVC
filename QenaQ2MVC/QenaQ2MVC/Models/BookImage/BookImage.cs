namespace QenaQ2MVC.Models
{
    public class BookImage
    {
        public int ID { get; set; }
        public string Path { get; set; }
        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
