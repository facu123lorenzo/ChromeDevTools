using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Information about the cached resource.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CachedResource
	{
		/// <summary>
		/// Gets or setsResource URL. This is the url of the original network request.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsType of this resource.

		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or setsCached response data.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Response Response { get; set; }
		/// <summary>
		/// Gets or setsCached response body size.

		/// </summary>
		public double BodySize { get; set; }
	}
}
