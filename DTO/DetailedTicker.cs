using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrapiSDK.DTO
{
	public class DetailedTicker
	{
		[JsonPropertyName("symbol")]
		public string symbol { get; set; }
		[JsonPropertyName("shortName")]
		public string shortName { get; set; }
		[JsonPropertyName("longName")]
		public string longName { get; set; }
		[JsonPropertyName("currency")]
		public string currency { get; set; }
		[JsonPropertyName("regularMarketPrice")]
		public float regularMarketPrice { get; set; }
		[JsonPropertyName("regularMarketDayHigh")]
		public int regularMarketDayHigh { get; set; }
		[JsonPropertyName("regularMarketDayLow")]
		public int regularMarketDayLow { get; set; }
		[JsonPropertyName("regularMarketDayRange")]
		public string regularMarketDayRange { get; set; }
		[JsonPropertyName("regularMarketChange")]
		public float regularMarketChange { get; set; }
		[JsonPropertyName("regularMarketChangePercent")]
		public float regularMarketChangePercent { get; set; }
		[JsonPropertyName("regularMarketTime")]
		public DateTime regularMarketTime { get; set; }
		[JsonPropertyName("marketCap")]
		public long marketCap { get; set; }
		[JsonPropertyName("regularMarketVolume")]
		public int regularMarketVolume { get; set; }
		[JsonPropertyName("regularMarketPreviousClose")]
		public float regularMarketPreviousClose { get; set; }
		[JsonPropertyName("regularMarketOpen")]
		public int regularMarketOpen { get; set; }
		[JsonPropertyName("averageDailyVolume10Day")]
		public int averageDailyVolume10Day { get; set; }
		[JsonPropertyName("averageDailyVolume3Month")]
		public int averageDailyVolume3Month { get; set; }
		[JsonPropertyName("fiftyTwoWeekLowChange")]
		public float fiftyTwoWeekLowChange { get; set; }
		[JsonPropertyName("fiftyTwoWeekRange")]
		public string fiftyTwoWeekRange { get; set; }
		[JsonPropertyName("fiftyTwoWeekHighChange")]
		public float fiftyTwoWeekHighChange { get; set; }
		[JsonPropertyName("fiftyTwoWeekHighChangePercent")]
		public float fiftyTwoWeekHighChangePercent { get; set; }
		[JsonPropertyName("fiftyTwoWeekLow")]
		public int fiftyTwoWeekLow { get; set; }
		[JsonPropertyName("fiftyTwoWeekHigh")]
		public float fiftyTwoWeekHigh { get; set; }
		[JsonPropertyName("twoHundredDayAverage")]
		public float twoHundredDayAverage { get; set; }
		[JsonPropertyName("twoHundredDayAverageChange")]
		public float twoHundredDayAverageChange { get; set; }
		[JsonPropertyName("twoHundredDayAverageChangePercent")]
		public float twoHundredDayAverageChangePercent { get; set; }
		[JsonPropertyName("validRanges")]
		public string[] validRanges { get; set; }
		[JsonPropertyName("historicalDataPrice")]
		public HistoricalDataPrice[] historicalDataPrice { get; set; }
		[JsonPropertyName("priceEarnings")]
		public float priceEarnings { get; set; }
		[JsonPropertyName("earningsPerShare")]
		public float earningsPerShare { get; set; }
		[JsonPropertyName("logourl")]
		public string logourl { get; set; }
	}
}
