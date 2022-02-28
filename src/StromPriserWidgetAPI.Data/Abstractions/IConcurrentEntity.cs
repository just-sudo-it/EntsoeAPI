namespace StromPriserWidgetAPI.Data.Entities;

using System.ComponentModel.DataAnnotations;

public interface IConcurrentEntity
{
  public byte[] RowVersion { get; set; }
}
