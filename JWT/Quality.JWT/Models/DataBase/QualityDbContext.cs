using Microsoft.EntityFrameworkCore;
using Quality.JWT.Models.Entities;

namespace Quality.JWT.Models.DataBase
{
    public class QualityDbContext : DbContext
    {
        public QualityDbContext(DbContextOptions<QualityDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}
