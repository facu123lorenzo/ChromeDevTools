using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///Fired when HTTP response is available.

	/// </summary>
	[Event(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("iOS")]
	public class ResponseReceivedEvent
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
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsResource type.

		/// </summary>
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or setsResponse data.

		/// </summary>
		public Response Response { get; set; }
	}
}
