namespace BrapiSDK.Test
{
	public class TestCurrency
	{
		[Theory]
		[InlineData("BRL")]
		[InlineData("BRL,USD")]
		[InlineData("")]
		public async Task TestGetAvailableCurrencyConversions(string currency)
		{
			BrapiClient client = new();
			DTO.CurrencyConversionAvailableResultMessage result = await client.GetAvailableCurrencyConversions(currency);
			Assert.True(result.CurrencyConversions.Count() > 0);
		}

		[Fact]
		public async Task TestGetAllCurrencies()
		{
			BrapiClient client = new();
			IEnumerable<(string symbol, string name)> result = await client.GetAllCurrencies();
			Assert.Contains("BRL", result.Select(r => r.symbol));
		}

		[Fact]
		public async Task TestGetAllCurrenciesWithDetails()
		{
			BrapiClient client = new();
			DTO.CurrencyConversionsResultMessage result = await client.GetCurrencyConversions("BRL-USD");
			Assert.Equal("BRL", result.CurrencyQuotes.First().FromCurrency);
		}
	}
}
