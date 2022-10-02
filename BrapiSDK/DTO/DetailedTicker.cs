using System.Text.Json.Serialization;

namespace BrapiSDK.DTO
{
	public class DetailedTicker
	{
		[JsonPropertyName("symbol")]
		public string Symbol { get; set; }
		[JsonPropertyName("shortName")]
		public string ShortName { get; set; }
		[JsonPropertyName("longName")]
		public string LongName { get; set; }
		[JsonPropertyName("currency")]
		public string Currency { get; set; }
		[JsonPropertyName("regularMarketPrice")]
		public float RegularMarketPrice { get; set; }
		[JsonPropertyName("regularMarketDayHigh")]
		public int RegularMarketDayHigh { get; set; }
		[JsonPropertyName("regularMarketDayLow")]
		public int RegularMarketDayLow { get; set; }
		[JsonPropertyName("regularMarketDayRange")]
		public string RegularMarketDayRange { get; set; }
		[JsonPropertyName("regularMarketChange")]
		public float RegularMarketChange { get; set; }
		[JsonPropertyName("regularMarketChangePercent")]
		public float RegularMarketChangePercent { get; set; }
		[JsonPropertyName("regularMarketTime")]
		public DateTime RegularMarketTime { get; set; }
		[JsonPropertyName("marketCap")]
		public long MarketCap { get; set; }
		[JsonPropertyName("regularMarketVolume")]
		public int RegularMarketVolume { get; set; }
		[JsonPropertyName("regularMarketPreviousClose")]
		public float RegularMarketPreviousClose { get; set; }
		[JsonPropertyName("regularMarketOpen")]
		public int RegularMarketOpen { get; set; }
		[JsonPropertyName("averageDailyVolume10Day")]
		public int AverageDailyVolume10Day { get; set; }
		[JsonPropertyName("averageDailyVolume3Month")]
		public int AverageDailyVolume3Month { get; set; }
		[JsonPropertyName("fiftyTwoWeekLowChange")]
		public float FiftyTwoWeekLowChange { get; set; }
		[JsonPropertyName("fiftyTwoWeekRange")]
		public string FiftyTwoWeekRange { get; set; }
		[JsonPropertyName("fiftyTwoWeekHighChange")]
		public float FiftyTwoWeekHighChange { get; set; }
		[JsonPropertyName("fiftyTwoWeekHighChangePercent")]
		public float FiftyTwoWeekHighChangePercent { get; set; }
		[JsonPropertyName("fiftyTwoWeekLow")]
		public int FiftyTwoWeekLow { get; set; }
		[JsonPropertyName("fiftyTwoWeekHigh")]
		public float FiftyTwoWeekHigh { get; set; }
		[JsonPropertyName("twoHundredDayAverage")]
		public float TwoHundredDayAverage { get; set; }
		[JsonPropertyName("twoHundredDayAverageChange")]
		public float TwoHundredDayAverageChange { get; set; }
		[JsonPropertyName("twoHundredDayAverageChangePercent")]
		public float TwoHundredDayAverageChangePercent { get; set; }
		[JsonPropertyName("validRanges")]
		public string[] ValidRanges { get; set; }
		[JsonPropertyName("historicalDataPrice")]
		public HistoricalDataPrice[] HistoricalDataPrice { get; set; }
		[JsonPropertyName("priceEarnings")]
		public float PriceEarnings { get; set; }
		[JsonPropertyName("earningsPerShare")]
		public float EarningsPerShare { get; set; }
		[JsonPropertyName("logourl")]
		public string Logourl { get; set; }
	}
}
