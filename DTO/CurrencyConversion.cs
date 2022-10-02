using System.Text.Json.Serialization;

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
