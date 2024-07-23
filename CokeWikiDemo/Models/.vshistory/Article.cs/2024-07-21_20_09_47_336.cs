using System.ComponentModel.DataAnnotations;

namespace CokeWikiDemo.Models
{
    public class Article
    {
        [Required, Key]
        public string? Topic { get; set; }

        private DateTime _published = DateTime.UtcNow;
        public DateTime Published
        {
            get
            {
                return _published;
            }
        }

        [DataType(DataType.MultilineText)]
        public string? Content { get; set; }
    }
}
