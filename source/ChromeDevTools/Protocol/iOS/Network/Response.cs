using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///HTTP response data.

	/// </summary>
	[SupportedBy("iOS")]
	public class Response
	{
		/// <summary>
		/// Gets or setsResponse URL. This URL can be different from CachedResource.url in case of redirect.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status code.

		/// </summary>
		public double Status { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status text.

		/// </summary>
		public string StatusText { get; set; }
		/// <summary>
		/// Gets or setsHTTP response headers.

		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or setsHTTP response headers text.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string HeadersText { get; set; }
		/// <summary>
		/// Gets or setsResource mimeType as determined by the browser.

		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or setsRefined HTTP request headers that were actually transmitted over the network.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> RequestHeaders { get; set; }
		/// <summary>
		/// Gets or setsHTTP request headers text.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestHeadersText { get; set; }
		/// <summary>
		/// Gets or setsSpecifies that the request was served from the disk cache.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromDiskCache { get; set; }
		/// <summary>
		/// Gets or setsTiming information for the given request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceTiming Timing { get; set; }
	}
}
