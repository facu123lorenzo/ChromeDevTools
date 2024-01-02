using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class BackForwardCacheNotRestoredExplanation
	{
		/// <summary>
		/// Gets or setsType of the reason

		/// </summary>
		public BackForwardCacheNotRestoredReasonType Type { get; set; }
		/// <summary>
		/// Gets or setsNot restored reason

		/// </summary>
		public BackForwardCacheNotRestoredReason Reason { get; set; }
		/// <summary>
		/// Gets or setsContext associated with the reason. The meaning of this context is
		/// dependent on the reason:
		/// - EmbedderExtensionSentMessageToCachedFrame: the extension ID.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Context { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BackForwardCacheBlockingDetails[] Details { get; set; }
	}
}
