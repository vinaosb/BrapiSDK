using BrapiSDK.DTO;

namespace BrapiSDK;
public class BrapiClient : IDisposable
{
	private HttpClient HttpClientBrapi { get; }
	public BrapiClient()
	{
		HttpClientBrapi = new HttpClient
		{
			BaseAddress = new Uri("https://brapi.dev/api/"),
			Timeout = TimeSpan.FromSeconds(30)
		};
	}

	public async Task<AvailableCoinsResultMessage> GetAvailableCoins(string search = "")
	{
		string uri = "v2/crypto/available";
		Dictionary<string, string> query = new()
		{
			["search"] = search
		};
		return await HttpClientBrapi.GetFromJsonWithQueryStringAsync<AvailableCoinsResultMessage>(uri, query);
	}

	public async Task<AvailableTickerResultMessage> GetAvailableTicker(string search = "")
	{
		string uri = "available";
		Dictionary<string, string> query = new()
		{
			["search"] = search
		};

		return await HttpClientBrapi.GetFromJsonWithQueryStringAsync<AvailableTickerResultMessage>(uri, query);
	}

	public async Task<CurrencyConversionAvailableResultMessage> GetAvailableCurrencyConversions(string currency = "")
	{
		string uri = "v2/currency/available";
		Dictionary<string, string> query = new()
		{
			["currency"] = currency
		};
		return await HttpClientBrapi.GetFromJsonWithQueryStringAsync<CurrencyConversionAvailableResultMessage>(uri, query);
	}

	public async Task<CryptoResultMessage> GetCryptoDetails(string coins, string currency)
	{
		if (string.IsNullOrWhiteSpace(coins))
		{
			throw new ArgumentException($"'{nameof(coins)}' cannot be null nor whitespace.", nameof(coins));
		}

		string uri = "v2/crypto";
		Dictionary<string, string> query = new()
		{
			["coin"] = coins,
			["currency"] = currency
		};
		return await HttpClientBrapi.GetFromJsonWithQueryStringAsync<CryptoResultMessage>(uri, query);
	}

	public async Task<DetailedTickerResultMessage> GetTickerQuote(
		string tickers,
		string range = "",
		string timeframe = "",
		bool fundamental = false)
	{
		if (string.IsNullOrEmpty(tickers))
		{
			throw new ArgumentException($"'{nameof(tickers)}' cannot be null nor whitespace.", nameof(tickers));
		}

		if (!Range.IsValid(range))
		{
			throw new ArgumentException($"'{nameof(range)}' is invalid, check class Range.", nameof(range));
		}

		if (!Range.IsValid(timeframe))
		{
			throw new ArgumentException($"'{nameof(timeframe)}' is invalid, check class Range.", nameof(timeframe));
		}

		string uri = $"quote/{tickers}";

		Dictionary<string, string> query = new()
		{
			["range"] = range,
			["interval"] = timeframe,
			["fundamental"] = fundamental.ToString().ToLower()
		};
		DetailedTickerResultMessage result = await HttpClientBrapi.GetFromJsonWithQueryStringAsync<DetailedTickerResultMessage>(uri, query);

		return result;
	}

	public async Task<SummaryTickerResultMessage> GetSummaryForTickers(
		string sortBy = "",
		string sortOrder = "",
		uint limit = 100)
	{
		if (!SortBy.IsValid(sortBy))
		{
			throw new ArgumentException($"'{nameof(sortBy)}' is invalid, check class SortBy.", nameof(sortBy));
		}

		if (!SortOrder.IsValid(sortOrder))
		{
			throw new ArgumentException($"'{nameof(sortOrder)}' is invalid, check class SortOrder.", nameof(sortOrder));
		}

		string uri = "quote/list";
		Dictionary<string, string> query = new()
		{
			["sortBy"] = sortBy,
			["sortOrder"] = sortOrder,
			["limit"] = limit.ToString()
		};
		if (limit == 0)
		{
			query["limit"] = "100";
		}

		return await HttpClientBrapi.GetFromJsonWithQueryStringAsync<SummaryTickerResultMessage>(uri, query);
	}

	public async Task<CurrencyConversionsResultMessage> GetCurrencyConversions(string currency)
	{
		if (string.IsNullOrWhiteSpace(currency))
		{
			throw new ArgumentException($"'{nameof(currency)}' cannot be null nor whitespace.", nameof(currency));
		}

		string uri = "v2/currency";
		Dictionary<string, string> query = new()
		{
			["currency"] = currency
		};
		return await HttpClientBrapi.GetFromJsonWithQueryStringAsync<CurrencyConversionsResultMessage>(uri, query);
	}

	public async Task<IEnumerable<(string symbol, string name)>> GetAllCurrencies()
	{
		List<(string symbol, string name)> currencies = new();
		using HttpClient client = new();
		client.BaseAddress = new Uri("https://economia.awesomeapi.com.br/json/available/uniq");
		string result = await client.GetStringAsync("");
		string[] splits = result.Split(",");
		foreach (string split in splits)
		{
			string currencyString = split.Replace("{", string.Empty).Replace("}", string.Empty).Replace("\"", string.Empty);

			(string symbol, string name) currency = new() { name = currencyString.Split(":")[1], symbol = currencyString.Split(":")[0] };

			currencies.Add(currency);
		}
		return currencies;
	}

	public void Dispose()
	{
		HttpClientBrapi.Dispose();
	}
}
