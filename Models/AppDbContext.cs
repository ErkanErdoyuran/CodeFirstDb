using Microsoft.EntityFrameworkCore;

namespace Ders23.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            string connectionString = "Data Source=DESKTOP-BHSNA8A; Initial Catalog=BlogDb; Integrated Security=SSPI;";

            builder.UseSqlServer(connectionString);
        }
    }

}

