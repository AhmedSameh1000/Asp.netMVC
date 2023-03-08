using System.ComponentModel.DataAnnotations;

namespace crud2.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }
    }
}