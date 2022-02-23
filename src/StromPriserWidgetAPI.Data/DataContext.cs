namespace Kritikos.StromPriserWidgetAPI.Data
{
  using Microsoft.EntityFrameworkCore;

  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options)
      : base(options)
    {
    }

    public DbSet<string> Zones { get; set; }

    public DbSet<string> Prices { get; set; }
  }
}
