namespace BrapiSDK.Test
{
	public class TestCrypto
	{
		[Theory]
		[InlineData("BTC")]
		[InlineData("ETH")]
		[InlineData("")]
		public async Task TestGetAvailableCoins(string search)
		{
			BrapiClient client = new();
			DTO.AvailableCoinsResultMessage result = await client.GetAvailableCoins(search);
			Assert.True(result.Coins.Count() > 0);
		}

		[Fact]
		public async Task TestGetCryptoDetails()
		{
			BrapiClient client = new();
			DTO.CryptoResultMessage result = await client.GetCryptoDetails("BTC,ETH", "BRL");
			Assert.True(result.Coins.Count() > 0);
		}
	}
}
