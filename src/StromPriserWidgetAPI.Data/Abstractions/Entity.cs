namespace StromPriserWidgetAPI.Data
{
  using StromPriserWidgetAPI.Data.Entities;

  public abstract class Entity<TKey> : IConcurrentEntity
  {
    public TKey? Id { get; set; }

    public byte[] RowVersion { get; set; }
  }
}
