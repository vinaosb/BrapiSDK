using System.Text.Json.Serialization;

namespace BrapiSDK.DTO
{
#nullable enable
	public class HistoricalDataPrice
	{
		[JsonPropertyName("date")]
		public int? Date { get; set; }
		[JsonPropertyName("open")]
		public float? Open { get; set; }
		[JsonPropertyName("high")]
		public float? High { get; set; }
		[JsonPropertyName("low")]
		public float? Low { get; set; }
		[JsonPropertyName("close")]
		public float? Close { get; set; }
		[JsonPropertyName("volume")]
		public long? Volume { get; set; }
	}
}
