using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CheckList.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<ChkList> ChkLists { get; set; }
    }
}
    