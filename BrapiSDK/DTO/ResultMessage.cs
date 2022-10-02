using System.Text.Json.Serialization;

namespace BrapiSDK.DTO
{

	public class DetailedTickerResultMessage
	{
		[JsonPropertyName("results")]
		public DetailedTicker[] Quotes { get; set; }
		[JsonPropertyName("requestedAt")]
		public DateTime RequestedAt { get; set; }
	}


	public class AvailableTickerResultMessage
	{
		[JsonPropertyName("stocks")]
		public IEnumerable<string> Tickers { get; set; }
	}


	public class SummaryTickerResultMessage
	{
		[JsonPropertyName("stocks")]
		public IEnumerable<Ticker> Tickers { get; set; }
	}


	public class CryptoResultMessage
	{
		[JsonPropertyName("coins")]
		public IEnumerable<CryptoCoin> Coins { get; set; }
	}

	public class AvailableCoinsResultMessage
	{
		[JsonPropertyName("coins")]
		public IEnumerable<string> Coins { get; set; }
	}

	public class CurrencyConversionsResultMessage
	{
		[JsonPropertyName("currency")]
		public IEnumerable<CurrencyQuotes> CurrencyQuotes { get; set; }
	}


	public class CurrencyConversionAvailableResultMessage
	{
		[JsonPropertyName("currencies")]
		public IEnumerable<CurrencyConversion> CurrencyConversions { get; set; }
	}

}
