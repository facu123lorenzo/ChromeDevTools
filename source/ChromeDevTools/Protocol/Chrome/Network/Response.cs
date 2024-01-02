using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///HTTP response data.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Response
	{
		/// <summary>
		/// Gets or setsResponse URL. This URL can be different from CachedResource.url in case of redirect.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status code.

		/// </summary>
		public long Status { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status text.

		/// </summary>
		public string StatusText { get; set; }
		/// <summary>
		/// Gets or setsHTTP response headers.

		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or setsHTTP response headers text. This has been replaced by the headers in Network.responseReceivedExtraInfo.

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
		/// Gets or setsHTTP request headers text. This has been replaced by the headers in Network.requestWillBeSentExtraInfo.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestHeadersText { get; set; }
		/// <summary>
		/// Gets or setsSpecifies whether physical connection was actually reused for this request.

		/// </summary>
		public bool ConnectionReused { get; set; }
		/// <summary>
		/// Gets or setsPhysical connection id that was actually used for this request.

		/// </summary>
		public double ConnectionId { get; set; }
		/// <summary>
		/// Gets or setsRemote IP address.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RemoteIPAddress { get; set; }
		/// <summary>
		/// Gets or setsRemote port.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? RemotePort { get; set; }
		/// <summary>
		/// Gets or setsSpecifies that the request was served from the disk cache.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromDiskCache { get; set; }
		/// <summary>
		/// Gets or setsSpecifies that the request was served from the ServiceWorker.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromServiceWorker { get; set; }
		/// <summary>
		/// Gets or setsSpecifies that the request was served from the prefetch cache.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromPrefetchCache { get; set; }
		/// <summary>
		/// Gets or setsInfomation about how Service Worker Static Router was used.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ServiceWorkerRouterInfo ServiceWorkerRouterInfo { get; set; }
		/// <summary>
		/// Gets or setsTotal number of bytes received for this request so far.

		/// </summary>
		public double EncodedDataLength { get; set; }
		/// <summary>
		/// Gets or setsTiming information for the given request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceTiming Timing { get; set; }
		/// <summary>
		/// Gets or setsResponse source of response from ServiceWorker.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ServiceWorkerResponseSource ServiceWorkerResponseSource { get; set; }
		/// <summary>
		/// Gets or setsThe time at which the returned response was generated.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ResponseTime { get; set; }
		/// <summary>
		/// Gets or setsCache Storage Cache Name.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CacheStorageCacheName { get; set; }
		/// <summary>
		/// Gets or setsProtocol used to fetch this request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Protocol { get; set; }
		/// <summary>
		/// Gets or setsThe reason why Chrome uses a specific transport protocol for HTTP semantics.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AlternateProtocolUsage AlternateProtocolUsage { get; set; }
		/// <summary>
		/// Gets or setsSecurity state of the request resource.

		/// </summary>
		public Security.SecurityState SecurityState { get; set; }
		/// <summary>
		/// Gets or setsSecurity details for the request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SecurityDetails SecurityDetails { get; set; }
	}
}
