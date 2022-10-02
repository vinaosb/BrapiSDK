using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrapiSDK.DTO
{
	public class CryptoCoin
	{
		[JsonPropertyName("currency")]
		public string Currency { get; set; }
		[JsonPropertyName("currencyRateFromUSD")]
		public float CurrencyRateFromUSD { get; set; }
		[JsonPropertyName("coinName")]
		public string CoinName { get; set; }
		[JsonPropertyName("coin")]
		public string Coin { get; set; }
		[JsonPropertyName("regularMarketChange")]
		public float RegularMarketChange { get; set; }
		[JsonPropertyName("regularMarketPrice")]
		public float RegularMarketPrice { get; set; }
		[JsonPropertyName("regularMarketChangePercent")]
		public float RegularMarketChangePercent { get; set; }
		[JsonPropertyName("regularMarketDayLow")]
		public float RegularMarketDayLow { get; set; }
		[JsonPropertyName("regularMarketDayHigh")]
		public float RegularMarketDayHigh { get; set; }
		[JsonPropertyName("regularMarketDayRange")]
		public string RegularMarketDayRange { get; set; }
		[JsonPropertyName("regularMarketVolume")]
		public float RegularMarketVolume { get; set; }
		[JsonPropertyName("marketCap")]
		public float MarketCap { get; set; }
		[JsonPropertyName("regularMarketTime")]
		public int RegularMarketTime { get; set; }
		[JsonPropertyName("coinImageUrl")]
		public string CoinImageUrl { get; set; }
	}
}
