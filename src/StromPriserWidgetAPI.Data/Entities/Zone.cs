namespace StromPriserWidgetAPI.Data.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class Zone : StromPriserEntity<long, Zone>
{
  public string Name { get; set; } = string.Empty;

  internal static void OnModelCreating(ModelBuilder builder)
  {
    EntityTypeBuilder<Zone> e = builder.Entity<Zone>();
    StromPriserEntity<long, Zone>.OnModelCreating(e);

    e.Property(z => z.Name).IsRequired();
  }
}
