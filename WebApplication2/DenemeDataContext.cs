using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2
{
    public class DenemeDataContext : DbContext
    {
        public DenemeDataContext(DbContextOptions<DenemeDataContext> options)
            : base(options)
        { 
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.UseSerialColumns();
        }
        
        public DbSet<Deneme> denemes { get; set; }
    }
}
