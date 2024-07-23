using Microsoft.EntityFrameworkCore;

namespace CokeWikiDemo.Models.DbContext
{
    public class ApplicationDbContext : DbContext(options)
    {
        public ApplicationDbContext(DbContextOptions options) 
        {
            
        }
    }
}
