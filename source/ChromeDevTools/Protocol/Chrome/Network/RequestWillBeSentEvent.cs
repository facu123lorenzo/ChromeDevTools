using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when page is about to send HTTP request.

	/// </summary>
	[Event(ProtocolName.Network.RequestWillBeSent)]
	[SupportedBy("Chrome")]
	public class RequestWillBeSentEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsLoader identifier. Empty string if the request is fetched from worker.

		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or setsURL of the document this request is loaded for.

		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or setsRequest data.

		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsTimestamp.

		/// </summary>
		public double WallTime { get; set; }
		/// <summary>
		/// Gets or setsRequest initiator.

		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or setsIn the case that redirectResponse is populated, this flag indicates whether
		/// requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be or were emitted
		/// for the request which was just redirected.

		/// </summary>
		public bool RedirectHasExtraInfo { get; set; }
		/// <summary>
		/// Gets or setsRedirect response data.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Response RedirectResponse { get; set; }
		/// <summary>
		/// Gets or setsType of this resource.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or setsFrame identifier.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsWhether the request is initiated by a user gesture. Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? HasUserGesture { get; set; }
	}
}
