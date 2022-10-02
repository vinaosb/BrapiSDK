
using Microsoft.AspNetCore.WebUtilities;
using System.Net.Http.Json;

namespace BrapiSDK
{

	public static class HttpClientExtensions
	{
		public static async Task<HttpResponseMessage> GetWithQueryStringAsync(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			var url = QueryHelpers.AddQueryString(uri, queryStringParams);

			return await client.GetAsync(url, cancellationToken);
		}
		public static async Task<T> GetFromJsonWithQueryStringAsync<T>(this HttpClient client, string uri, 
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			var url = QueryHelpers.AddQueryString(uri, queryStringParams);

			return await client.GetFromJsonAsync<T>(url, cancellationToken);
		}
		public static async Task<string> GetStringWithQueryStringAsync(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			var url = QueryHelpers.AddQueryString(uri, queryStringParams);

			return await client.GetStringAsync(url, cancellationToken);
		}
		public static async Task<Stream> GetStreamWithQueryStringAsync(this HttpClient client, string uri,
			Dictionary<string, string> queryStringParams, CancellationToken cancellationToken = default)
		{
			var url = QueryHelpers.AddQueryString(uri, queryStringParams);

			return await client.GetStreamAsync(url, cancellationToken);
		}
	}
}
