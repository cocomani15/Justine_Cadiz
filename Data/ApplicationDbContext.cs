using Microsoft.EntityFrameworkCore;
using webdev.Models;

namespace webdev.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
        public DbSet<item> items { get; set; }


        public DbSet<Type> typs {get; set;}

        
    }
}