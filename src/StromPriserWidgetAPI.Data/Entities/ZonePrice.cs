namespace StromPriserWidgetAPI.Data.Entities;
public class ZonePrice : StromPriserEntity<long, ZonePrice>
{
  public Zone Zone { get; set; } = new Zone();

  // NOK/kW
  public float Price { get; set; }
  public DateTime Date { get; set; }
}
