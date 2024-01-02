using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///HTTP request data.

	/// </summary>
	[SupportedBy("iOS")]
	public class Request
	{
		/// <summary>
		/// Gets or setsRequest URL.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsHTTP request method.

		/// </summary>
		public string Method { get; set; }
		/// <summary>
		/// Gets or setsHTTP request headers.

		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or setsHTTP POST request data.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PostData { get; set; }
	}
}
