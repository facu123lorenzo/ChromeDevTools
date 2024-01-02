using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///Fired when page is about to send HTTP request.

	/// </summary>
	[Event(ProtocolName.Network.RequestWillBeSent)]
	[SupportedBy("iOS")]
	public class RequestWillBeSentEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsFrame identifier.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsLoader identifier.

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
		/// Gets or setsRequest initiator.

		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or setsRedirect response data.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Response RedirectResponse { get; set; }
		/// <summary>
		/// Gets or setsResource type.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Page.ResourceType Type { get; set; }
	}
}
