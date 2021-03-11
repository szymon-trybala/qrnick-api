using Microsoft.EntityFrameworkCore;
using qrnick_api.Entities;

namespace qrnick_api.Data
{
  public class DataContext : DbContext
  {
    public DbSet<AppUser> Users { get; set; }
    public DataContext(DbContextOptions options) : base(options)
    {
    }
  }
}