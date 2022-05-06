namespace StromPriserWidgetAPI.Models;

using System.Xml.Serialization;
using System.ComponentModel;

#pragma warning disable SA1516 // Elements should be separated by blank line
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
[XmlRoot("Publication_MarketDocument", Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0", IsNullable = false)]
public partial class EntsoeDocument
{
  private string mRIDField;
  private byte revisionNumberField;
  private string typeField;
  private SenderMarketParticipantmRID senderMarketParticipantmRIDField;
  private string senderMarketParticipantmarketRoletypeField;
  private ReceiverMarketParticipantmRID receiverMarketParticipantmRIDField;
  private string receiverMarketParticipantmarketRoletypeField;
  private DateTime createdDateTimeField;
  private PeriodtimeInterval periodtimeIntervalField;
  private TimeSeries timeSeriesField;

  [XmlElement("mRID")]
  public string MRID
  {
    get
    {
      return this.mRIDField;
    }
    set
    {
      this.mRIDField = value;
    }
  }

  [XmlElement("revisionNumber")]
  public byte RevisionNumber
  {
    get
    {
      return this.revisionNumberField;
    }
    set
    {
      this.revisionNumberField = value;
    }
  }

  [XmlElement("type")]
  public string Type
  {
    get
    {
      return this.typeField;
    }
    set
    {
      this.typeField = value;
    }
  }

  [XmlElement("sender_MarketParticipant.mRID")]
  public SenderMarketParticipantmRID SenderMarketParticipantmRID
  {
    get
    {
      return this.senderMarketParticipantmRIDField;
    }
    set
    {
      this.senderMarketParticipantmRIDField = value;
    }
  }

  [XmlElement("sender_MarketParticipant.marketRole.type")]
  public string SenderMarketParticipantmarketRoletype
  {
    get
    {
      return this.senderMarketParticipantmarketRoletypeField;
    }
    set
    {
      this.senderMarketParticipantmarketRoletypeField = value;
    }
  }

  [XmlElement("receiver_MarketParticipant.mRID")]
  public ReceiverMarketParticipantmRID ReceiverMarketParticipantmRID
  {
    get
    {
      return this.receiverMarketParticipantmRIDField;
    }
    set
    {
      this.receiverMarketParticipantmRIDField = value;
    }
  }

  [XmlElement("receiver_MarketParticipant.marketRole.type")]
  public string ReceiverMarketParticipantmarketRoletype
  {
    get
    {
      return this.receiverMarketParticipantmarketRoletypeField;
    }
    set
    {
      this.receiverMarketParticipantmarketRoletypeField = value;
    }
  }

  [XmlElement("createdDateTime")]
  public DateTime CreatedDateTime
  {
    get
    {
      return this.createdDateTimeField;
    }
    set
    {
      this.createdDateTimeField = value;
    }
  }

  [XmlElement("period.timeInterval")]
  public PeriodtimeInterval PeriodtimeInterval
  {
    get
    {
      return this.periodtimeIntervalField;
    }
    set
    {
      this.periodtimeIntervalField = value;
    }
  }

  [XmlElement("TimeSeries")]
  public TimeSeries TimeSeries
  {
    get
    {
      return this.timeSeriesField;
    }
    set
    {
      this.timeSeriesField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class SenderMarketParticipantmRID
{
  private string codingSchemeField;
  private string valueField;

  [XmlAttribute]
  public string codingScheme
  {
    get
    {
      return this.codingSchemeField;
    }
    set
    {
      this.codingSchemeField = value;
    }
  }

  [XmlText]
  public string Value
  {
    get
    {
      return this.valueField;
    }
    set
    {
      this.valueField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class ReceiverMarketParticipantmRID
{
  private string codingSchemeField;
  private string valueField;

  [XmlAttribute]
  public string CodingScheme
  {
    get
    {
      return this.codingSchemeField;
    }
    set
    {
      this.codingSchemeField = value;
    }
  }

  [XmlText]
  public string Value
  {
    get
    {
      return this.valueField;
    }
    set
    {
      this.valueField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class PeriodtimeInterval
{
  private string startField;
  private string endField;

  public string start
  {
    get
    {
      return this.startField;
    }
    set
    {
      this.startField = value;
    }
  }

  public string end
  {
    get
    {
      return this.endField;
    }
    set
    {
      this.endField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class TimeSeries
{
  private byte mRIDField;
  private string businessTypeField;
  private InDomainmRID inDomainmRIDField;
  private OutDomainmRID outDomainmRIDField;
  private string currencyUnitnameField;
  private string priceMeasureUnitnameField;
  private string curveTypeField;
  private Period periodField;

  public byte MRID
  {
    get
    {
      return this.mRIDField;
    }
    set
    {
      this.mRIDField = value;
    }
  }

  public string BusinessType
  {
    get
    {
      return this.businessTypeField;
    }
    set
    {
      this.businessTypeField = value;
    }
  }

  [XmlElement("in_Domain.mRID")]
  public InDomainmRID InDomainMRID
  {
    get
    {
      return this.inDomainmRIDField;
    }
    set
    {
      this.inDomainmRIDField = value;
    }
  }

  [XmlElement("out_Domain.mRID")]
  public OutDomainmRID OutDomainmRID
  {
    get
    {
      return this.outDomainmRIDField;
    }
    set
    {
      this.outDomainmRIDField = value;
    }
  }

  [XmlElement("currency_Unit.name")]
  public string CurrencyUnitname
  {
    get
    {
      return this.currencyUnitnameField;
    }
    set
    {
      this.currencyUnitnameField = value;
    }
  }

  [XmlElement("price_Measure_Unit.name")]
  public string PriceMeasureUnitname
  {
    get
    {
      return this.priceMeasureUnitnameField;
    }
    set
    {
      this.priceMeasureUnitnameField = value;
    }
  }

  public string CurveType
  {
    get
    {
      return this.curveTypeField;
    }
    set
    {
      this.curveTypeField = value;
    }
  }

  public Period Period
  {
    get
    {
      return this.periodField;
    }
    set
    {
      this.periodField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class InDomainmRID
{
  private string codingSchemeField;
  private string valueField;

  [XmlAttribute]
  public string CodingScheme
  {
    get
    {
      return this.codingSchemeField;
    }
    set
    {
      this.codingSchemeField = value;
    }
  }

  [XmlText]
  public string Value
  {
    get
    {
      return this.valueField;
    }
    set
    {
      this.valueField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class OutDomainmRID
{
  private string codingSchemeField;
  private string valueField;

  [XmlAttribute]
  public string CodingScheme
  {
    get
    {
      return this.codingSchemeField;
    }
    set
    {
      this.codingSchemeField = value;
    }
  }

  [XmlText]
  public string Value
  {
    get
    {
      return this.valueField;
    }
    set
    {
      this.valueField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Period
{
  private Interval timeIntervalField;
  private string resolutionField;
  private PeriodPoint[] pointField;

  public Interval TimeInterval
  {
    get
    {
      return this.timeIntervalField;
    }
    set
    {
      this.timeIntervalField = value;
    }
  }

  [XmlElement(DataType = "duration")]
  public string Resolution
  {
    get
    {
      return this.resolutionField;
    }
    set
    {
      this.resolutionField = value;
    }
  }

  [XmlElement("Point")]
  public PeriodPoint[] Point
  {
    get
    {
      return this.pointField;
    }
    set
    {
      this.pointField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Interval
{
  private string startField;
  private string endField;

  public string Start
  {
    get
    {
      return this.startField;
    }
    set
    {
      this.startField = value;
    }
  }

  public string End
  {
    get
    {
      return this.endField;
    }
    set
    {
      this.endField = value;
    }
  }
}

[Serializable]
[DesignerCategory("code")]
[XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class PeriodPoint
{
  private byte positionField;
  private decimal priceamountField;

  public byte Position
  {
    get
    {
      return this.positionField;
    }
    set
    {
      this.positionField = value;
    }
  }

  [XmlElement("price.amount")]
  public decimal PriceAmount
  {
    get
    {
      return this.priceamountField;
    }
    set
    {
      this.priceamountField = value;
    }
  }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore SA1516 // Elements should be separated by blank line
