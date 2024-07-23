using System.ComponentModel.DataAnnotations;

namespace CokeWikiDemo.Models
{
    public class Article
    {
        [Required, Key]
        public string? Topic { get; set; }
        public DateTime Published { get; set; } = DateTime.UtcNow;
        public string? Content { get; set; }
    }
}
