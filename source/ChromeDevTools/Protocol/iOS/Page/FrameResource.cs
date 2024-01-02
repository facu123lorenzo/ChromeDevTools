using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	[SupportedBy("iOS")]
	public class FrameResource
	{
		/// <summary>
		/// Gets or setsResource URL.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsType of this resource.

		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or setsResource mimeType as determined by the browser.

		/// </summary>
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or setsTrue if the resource failed to load.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Failed { get; set; }
		/// <summary>
		/// Gets or setsTrue if the resource was canceled during loading.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
		/// <summary>
		/// Gets or setsURL of source map associated with this resource (if any).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceMapURL { get; set; }
	}
}
