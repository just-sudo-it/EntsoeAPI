namespace StromPriserWidgetAPI.Data;

using Microsoft.EntityFrameworkCore.Metadata.Builders;

public abstract class StromPriserEntity<TKey, TEntity> : Entity<TKey>
  where TEntity : StromPriserEntity<TKey, TEntity>
{
  public override string ToString() => $"[{GetType().Name}#{Id}]";

  internal static void OnModelCreating(EntityTypeBuilder<TEntity> e)
  {
    e.HasKey(x => x.Id);
    e.Property(x => x.RowVersion).IsRowVersion();
  }
}
