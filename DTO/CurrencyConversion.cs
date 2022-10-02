using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BrapiSDK.DTO
{
	public class CurrencyConversion
	{
		[JsonPropertyName("name")]
		public string CurrencyConversionName { get; set; }
		[JsonPropertyName("currency")]
		public string ExtendedCurrencyConversionName { get; set; }
	}
}
