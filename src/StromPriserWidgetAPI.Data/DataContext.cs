namespace StromPriserWidgetAPI.Data
{
  using Microsoft.EntityFrameworkCore;

  using StromPriserWidgetAPI.Data.Entities;

  public class DataContext : DbContext
  {
    public DbSet<string> Zones { get; set; }

    public DbSet<string> Prices { get; set; }

    public DataContext(DbContextOptions<DataContext> options)
      : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      ZonePrice.OnModelCreating(modelBuilder);
    }
  }
}
