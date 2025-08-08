namespace StromPriserWidgetAPI.Data.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ZonePrice : StromPriserEntity<long, ZonePrice>
{
  public Zone Zone { get; set; } = null!;

  // NOK/kW
  public float Price { get; set; }
  public DateTime Date { get; set; }

  internal static void OnModelCreating(ModelBuilder builder)
  {
    EntityTypeBuilder<ZonePrice> e = builder.Entity<ZonePrice>();
    StromPriserEntity<long, ZonePrice>.OnModelCreating(e);

    e.HasOne(zp => zp.Zone).WithMany().IsRequired();
  }
}
