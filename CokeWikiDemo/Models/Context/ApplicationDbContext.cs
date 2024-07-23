using Microsoft.EntityFrameworkCore;

namespace CokeWikiDemo.Models.Context
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Article> Articles { get; set; }
    }
}
