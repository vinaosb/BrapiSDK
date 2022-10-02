using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrapiSDK.DTO
{

	public abstract class DetailedTickerResultMessage
	{
		[JsonPropertyName("results")]
		public DetailedTicker[] Quotes { get; set; }
		[JsonPropertyName("RequestedAt")]
		public DateTime RequestedAt { get; set; }
	}

	public class AvailableTickerResultMessage
	{
		[JsonPropertyName("stocks")]
		public string[] Tickers { get; set; }
	}


	public class SummaryTickerResultMessage
	{
		[JsonPropertyName("stocks")]
		public Ticker[] Tickers { get; set; }
	}


	public class CryptoResultMessage
	{
		[JsonPropertyName("coins")]
		public CryptoCoin[] Coins { get; set; }
	}

	public class AvailableCoinsResultMessage
	{
		[JsonPropertyName("coins")]
		public string[] Coins { get; set; }
	}

	public class CurrencyConversionsResultMessage
	{
		[JsonPropertyName("currency")]
		public CurrencyQuotes[] CurrencyQuotes { get; set; }
	}


	public class CurrencyConversionAvailableResultMessage
	{
		[JsonPropertyName("currencies")]
		public CurrencyConversion[] CurrencyConversions { get; set; }
	}
	

}
