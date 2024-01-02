using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when HTTP request has failed to load.

	/// </summary>
	[Event(ProtocolName.Network.LoadingFailed)]
	[SupportedBy("Chrome")]
	public class LoadingFailedEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsResource type.

		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or setsUser friendly error message.

		/// </summary>
		public string ErrorText { get; set; }
		/// <summary>
		/// Gets or setsTrue if loading was canceled.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Canceled { get; set; }
		/// <summary>
		/// Gets or setsThe reason why loading was blocked, if any.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BlockedReason BlockedReason { get; set; }
		/// <summary>
		/// Gets or setsThe reason why loading was blocked by CORS, if any.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CorsErrorStatus CorsErrorStatus { get; set; }
	}
}
