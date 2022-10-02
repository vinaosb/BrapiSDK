namespace BrapiSDK.Test
{
	public class TestTicker
	{

		[Theory]
		[InlineData("PETR4")]
		[InlineData("petr4")]
		[InlineData("COG")]
		[InlineData("")]
		public async Task TestGetAvailableTickers(string ticker)
		{
			BrapiClient client = new();
			DTO.AvailableTickerResultMessage result = await client.GetAvailableTicker(ticker);
			Assert.True(result.Tickers.Count() > 0);
		}

		[Theory]
		[InlineData("PETR4")]
		[InlineData("PETR4", "6mo", "5d", true)]
		[InlineData("PETR4,ITUB3", "6mo", "5d", true)]
		public async Task TestGetTickerQuote(
		string tickers,
		string range = "",
		string timeframe = "",
		bool fundamental = false)
		{
			BrapiClient client = new();
			DTO.DetailedTickerResultMessage result = await client.GetTickerQuote(tickers, range, timeframe, fundamental);
			Assert.True(result.Quotes.Count() > 0);
		}

		[Theory]
		[InlineData("name", "asc", 10)]
		[InlineData("name", "asc", 100)]
		public async Task TestGetSummaryForTickers(
		string sortBy = "",
		string sortOrder = "",
		uint limit = 0)
		{
			BrapiClient client = new();
			DTO.SummaryTickerResultMessage result = await client.GetSummaryForTickers(sortBy, sortOrder, limit);
			if (limit > 0)
			{
				Assert.True(result.Tickers.Count() == limit);
			}
			else
			{
				Assert.True(result.Tickers.Count() > 0);
			}
		}
	}
}
