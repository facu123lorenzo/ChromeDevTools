using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///WebSocket response data.

	/// </summary>
	[SupportedBy("Chrome")]
	public class WebSocketResponse
	{
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
		/// Gets or setsHTTP response headers text.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string HeadersText { get; set; }
		/// <summary>
		/// Gets or setsHTTP request headers.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> RequestHeaders { get; set; }
		/// <summary>
		/// Gets or setsHTTP request headers text.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestHeadersText { get; set; }
	}
}
