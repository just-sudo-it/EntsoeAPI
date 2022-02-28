namespace StromPriserWidgetAPI.Models;
#pragma warning disable SA1516 // Elements should be separated by blank line
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

[Serializable]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
[System.Xml.Serialization.XmlRoot(Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0", IsNullable = false)]
public partial class Publication_MarketDocument
{
  private string mRIDField;
  private byte revisionNumberField;
  private string typeField;
  private Publication_MarketDocumentSender_MarketParticipantmRID sender_MarketParticipantmRIDField;
  private string sender_MarketParticipantmarketRoletypeField;
  private Publication_MarketDocumentReceiver_MarketParticipantmRID receiver_MarketParticipantmRIDField;
  private string receiver_MarketParticipantmarketRoletypeField;
  private System.DateTime createdDateTimeField;
  private Publication_MarketDocumentPeriodtimeInterval periodtimeIntervalField;
  private Publication_MarketDocumentTimeSeries timeSeriesField;

  public string mRID
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

  public byte revisionNumber
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

  public string type
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

  [System.Xml.Serialization.XmlElement("sender_MarketParticipant.mRID")]
  public Publication_MarketDocumentSender_MarketParticipantmRID sender_MarketParticipantmRID
  {
    get
    {
      return this.sender_MarketParticipantmRIDField;
    }
    set
    {
      this.sender_MarketParticipantmRIDField = value;
    }
  }

  [System.Xml.Serialization.XmlElement("sender_MarketParticipant.marketRole.type")]
  public string sender_MarketParticipantmarketRoletype
  {
    get
    {
      return this.sender_MarketParticipantmarketRoletypeField;
    }
    set
    {
      this.sender_MarketParticipantmarketRoletypeField = value;
    }
  }

  [System.Xml.Serialization.XmlElement("receiver_MarketParticipant.mRID")]
  public Publication_MarketDocumentReceiver_MarketParticipantmRID receiver_MarketParticipantmRID
  {
    get
    {
      return this.receiver_MarketParticipantmRIDField;
    }
    set
    {
      this.receiver_MarketParticipantmRIDField = value;
    }
  }

  [System.Xml.Serialization.XmlElement("receiver_MarketParticipant.marketRole.type")]
  public string receiver_MarketParticipantmarketRoletype
  {
    get
    {
      return this.receiver_MarketParticipantmarketRoletypeField;
    }
    set
    {
      this.receiver_MarketParticipantmarketRoletypeField = value;
    }
  }

  public System.DateTime createdDateTime
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

  [System.Xml.Serialization.XmlElement("period.timeInterval")]
  public Publication_MarketDocumentPeriodtimeInterval periodtimeInterval
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

  public Publication_MarketDocumentTimeSeries TimeSeries
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

[Serializable()]
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentSender_MarketParticipantmRID
{

  private string codingSchemeField;

  private string valueField;

  [System.Xml.Serialization.XmlAttribute()]
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

  [System.Xml.Serialization.XmlText()]
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentReceiver_MarketParticipantmRID
{

  private string codingSchemeField;

  private string valueField;

  [System.Xml.Serialization.XmlAttribute]
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

  [System.Xml.Serialization.XmlTextAttribute()]
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentPeriodtimeInterval
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentTimeSeries
{

  private byte mRIDField;

  private string businessTypeField;

  private Publication_MarketDocumentTimeSeriesIn_DomainmRID in_DomainmRIDField;

  private Publication_MarketDocumentTimeSeriesOut_DomainmRID out_DomainmRIDField;

  private string currency_UnitnameField;

  private string price_Measure_UnitnameField;

  private string curveTypeField;

  private Publication_MarketDocumentTimeSeriesPeriod periodField;

  public byte mRID
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

  public string businessType
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

  [System.Xml.Serialization.XmlElement("in_Domain.mRID")]
  public Publication_MarketDocumentTimeSeriesIn_DomainmRID in_DomainmRID
  {
    get
    {
      return this.in_DomainmRIDField;
    }
    set
    {
      this.in_DomainmRIDField = value;
    }
  }

  [System.Xml.Serialization.XmlElement("out_Domain.mRID")]
  public Publication_MarketDocumentTimeSeriesOut_DomainmRID out_DomainmRID
  {
    get
    {
      return this.out_DomainmRIDField;
    }
    set
    {
      this.out_DomainmRIDField = value;
    }
  }

  [System.Xml.Serialization.XmlElement("currency_Unit.name")]
  public string currency_Unitname
  {
    get
    {
      return this.currency_UnitnameField;
    }
    set
    {
      this.currency_UnitnameField = value;
    }
  }

  [System.Xml.Serialization.XmlElement("price_Measure_Unit.name")]
  public string price_Measure_Unitname
  {
    get
    {
      return this.price_Measure_UnitnameField;
    }
    set
    {
      this.price_Measure_UnitnameField = value;
    }
  }

  public string curveType
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

  public Publication_MarketDocumentTimeSeriesPeriod Period
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentTimeSeriesIn_DomainmRID
{
  private string codingSchemeField;
  private string valueField;

  [System.Xml.Serialization.XmlAttributeAttribute()]
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
 
  [System.Xml.Serialization.XmlTextAttribute()]
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentTimeSeriesOut_DomainmRID
{

  private string codingSchemeField;

  private string valueField;

  [System.Xml.Serialization.XmlAttributeAttribute()]
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

  [System.Xml.Serialization.XmlTextAttribute()]
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentTimeSeriesPeriod
{

  private Publication_MarketDocumentTimeSeriesPeriodTimeInterval timeIntervalField;

  private string resolutionField;

  private Publication_MarketDocumentTimeSeriesPeriodPoint[] pointField;

  public Publication_MarketDocumentTimeSeriesPeriodTimeInterval timeInterval
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

  [System.Xml.Serialization.XmlElement(DataType = "duration")]
  public string resolution
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

  [System.Xml.Serialization.XmlElement("Point")]
  public Publication_MarketDocumentTimeSeriesPeriodPoint[] Point
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentTimeSeriesPeriodTimeInterval
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
[System.ComponentModel.DesignerCategory("code")]
[System.Xml.Serialization.XmlType(AnonymousType = true, Namespace = "urn:iec62325.351:tc57wg16:451-3:publicationdocument:7:0")]
public partial class Publication_MarketDocumentTimeSeriesPeriodPoint
{

  private byte positionField;

  private decimal priceamountField;
 
  public byte position
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

  [System.Xml.Serialization.XmlElement("price.amount")]
  public decimal priceamount
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
