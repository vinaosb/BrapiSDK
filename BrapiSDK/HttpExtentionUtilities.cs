using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Json;

namespace BrapiSDK
{

	public static class HttpClientExtensions
	{
		public static async Task<HttpResponseMessage> GetWithQueryStringAsync(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			IDictionary<string, string> queryParamsNotEmpty = queryStringParams.Where(qs => !string.IsNullOrEmpty(qs.Value)).ToDictionary(qs => qs.Key, qs => qs.Value);

			string url = queryParamsNotEmpty.Count() > 0 ? QueryHelpers.AddQueryString(uri, queryParamsNotEmpty) : uri;

			try
			{
				return await client.GetAsync(url, cancellationToken);

			}
			catch (Exception ex)
			{
				throw new Exception($"Error while trying to get {url}", ex);
			}
		}
		public static async Task<T> GetFromJsonWithQueryStringAsync<T>(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			IDictionary<string, string> queryParamsNotEmpty = queryStringParams.Where(qs => !string.IsNullOrEmpty(qs.Value)).ToDictionary(qs => qs.Key, qs => qs.Value);

			string url = queryParamsNotEmpty.Count() > 0 ? QueryHelpers.AddQueryString(uri, queryParamsNotEmpty) : uri;

			return await client.GetFromJsonAsync<T>(url, cancellationToken);
		}
		public static async Task<string> GetStringWithQueryStringAsync(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			IDictionary<string, string> queryParamsNotEmpty = queryStringParams.Where(qs => !string.IsNullOrEmpty(qs.Value)).ToDictionary(qs => qs.Key, qs => qs.Value);

			string url = queryParamsNotEmpty.Count() > 0 ? QueryHelpers.AddQueryString(uri, queryParamsNotEmpty) : uri;

			return await client.GetStringAsync(url, cancellationToken);
		}
		public static async Task<Stream> GetStreamWithQueryStringAsync(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			IDictionary<string, string> queryParamsNotEmpty = queryStringParams.Where(qs => !string.IsNullOrEmpty(qs.Value)).ToDictionary(qs => qs.Key, qs => qs.Value);

			string url = queryParamsNotEmpty.Count() > 0 ? QueryHelpers.AddQueryString(uri, queryParamsNotEmpty) : uri;

			return await client.GetStreamAsync(url, cancellationToken);
		}
	}
}
