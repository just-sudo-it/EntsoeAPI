namespace StromPriserWidgetAPI.Data.Entities;

using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

public class ZonePrice : StromPriserEntity<long, ZonePrice>
{
  [Required]
  public Zone Zone { get; set; }

  [Required]
  public DateTime Date { get; set; }

  public float Price { get; set; } // NOK/kW

  internal static void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<ZonePrice>(
      e =>
      {
        OnModelCreating(e);
        // e.HasIndex("ProjectId", "VesselId").IsUnique();
        // e.HasMany(x => x.Zones).WithOne(x => x.Assessment).IsRequired().OnDelete(DeleteBehavior.Restrict);
      });
  }
}
