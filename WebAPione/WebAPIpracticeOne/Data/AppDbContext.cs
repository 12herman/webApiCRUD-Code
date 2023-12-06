using Microsoft.EntityFrameworkCore;
using WebAPIpracticeOne.Models;

namespace WebAPIpracticeOne.Data
{
    public class AppDbContext : DbContext
    {

      public AppDbContext(DbContextOptions options) : base(options) { }
      public DbSet<StudentDetails> StudentDetails { get; set; }
    }
}
