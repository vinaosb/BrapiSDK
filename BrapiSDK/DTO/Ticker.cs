namespace BrapiSDK.DTO
{
	public class Ticker
	{
		public string stock { get; set; }
		public string name { get; set; }
		public float close { get; set; }
		public float change { get; set; }
		public int volume { get; set; }
		public float? market_cap { get; set; }
		public string logo { get; set; }
		public string sector { get; set; }
	}
}
