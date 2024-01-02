using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when HTTP response is available.

	/// </summary>
	[Event(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("Chrome")]
	public class ResponseReceivedEvent
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
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsResource type.

		/// </summary>
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or setsResponse data.

		/// </summary>
		public Response Response { get; set; }
		/// <summary>
		/// Gets or setsIndicates whether requestWillBeSentExtraInfo and responseReceivedExtraInfo events will be
		/// or were emitted for this request.

		/// </summary>
		public bool HasExtraInfo { get; set; }
		/// <summary>
		/// Gets or setsFrame identifier.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
