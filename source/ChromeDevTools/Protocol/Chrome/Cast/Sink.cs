using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Cast
{
	[SupportedBy("Chrome")]
	public class Sink
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or setsText describing the current session. Present only if there is an active
		/// session on the sink.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Session { get; set; }
	}
}
