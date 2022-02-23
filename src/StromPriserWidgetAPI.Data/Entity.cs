namespace StromPriserWidgetAPI.Data
{
  using System.ComponentModel.DataAnnotations;

  using Microsoft.EntityFrameworkCore.Metadata.Builders;

  public interface IConcurrentEntity
  {
    [Timestamp]
    public byte[] RowVersion { get; set; }
  }

  public abstract class Entity<TKey> : IConcurrentEntity
  {
    public TKey? Id { get; set; }

    [Timestamp]
    public byte[] RowVersion { get; set; }
  }

  public abstract class StromPriserEntity<TKey, TEntity> : Entity<TKey>
    where TEntity : StromPriserEntity<TKey, TEntity>
  {
    public override string ToString()
    {
      return $"[{GetType().Name}#{Id}]";
    }

    internal static void OnModelCreating(EntityTypeBuilder<TEntity> e)
    {
      e.HasKey(x => x.Id);
      e.Property(x => x.RowVersion).IsConcurrencyToken();
    }
  }
}
