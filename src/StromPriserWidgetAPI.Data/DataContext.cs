namespace StromPriserWidgetAPI.Data
{
  using Microsoft.EntityFrameworkCore;

  using StromPriserWidgetAPI.Data.Entities;

  public class DataContext : DbContext
  {
    public DbSet<Zone> Zones { get; set; } = null!;

    public DbSet<ZonePrice> Prices { get; set; } = null!;

    public DataContext(DbContextOptions options)
      : base(options)
    {
    }


    protected override void OnModelCreating(ModelBuilder builder)
    {
      base.OnModelCreating(builder);

      Zone.OnModelCreating(builder);
      ZonePrice.OnModelCreating(builder);
    }
  }
}
