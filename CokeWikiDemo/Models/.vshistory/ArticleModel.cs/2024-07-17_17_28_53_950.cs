namespace CokeWikiDemo.Models
{
    public class ArticleModel
    {
        public string? Topic { get; set; }
        public string? Content { get; set; }
        public DateTime Published { get; set; } = DateTime.UtcNow;
    }
}
