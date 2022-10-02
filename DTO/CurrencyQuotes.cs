using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrapiSDK.DTO
{
	public class CurrencyQuotes
	{
		[JsonPropertyName("fromCurrency")]
		public string FromCurrency { get; set; }
		[JsonPropertyName("toCurrency")]
		public string toCurrency { get; set; }
		[JsonPropertyName("name")]
		public string name { get; set; }
		[JsonPropertyName("high")]
		public string high { get; set; }
		[JsonPropertyName("low")]
		public string low { get; set; }
		[JsonPropertyName("bidVariation")]
		public string bidVariation { get; set; }
		[JsonPropertyName("percentageChange")]
		public string percentageChange { get; set; }
		[JsonPropertyName("bidPrice")]
		public string bidPrice { get; set; }
		[JsonPropertyName("askPrice")]
		public string askPrice { get; set; }
		[JsonPropertyName("updatedAtTimestamp")]
		public string updatedAtTimestamp { get; set; }
		[JsonPropertyName("updatedAtDate")]
		public string updatedAtDate { get; set; }
	}
}
