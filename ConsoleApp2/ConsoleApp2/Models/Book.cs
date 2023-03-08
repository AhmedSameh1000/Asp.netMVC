namespace ThirdApp.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public Auther auther { get; set; }
    }

}