// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class ExchangeRateList
{
    public string averageRate { get; set; }
    public string sellRate { get; set; }
    public string minorCurrency { get; set; }
    public string previousDaySellRate { get; set; }
    public string majorCurrency { get; set; }
    public string changeRatioDaily { get; set; }
    public string previousDayBuyRate { get; set; }
    public string previousDayAverageRate { get; set; }
    public string buyRate { get; set; }
}

public class Response
{
    public List<ExchangeRateList> exchangeRateList { get; set; }
}

public class Root
{
    public Response? response { get; set; }
}

