using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when WebSocket message is received.

	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameReceived)]
	[SupportedBy("Chrome")]
	public class WebSocketFrameReceivedEvent
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
		/// Gets or setsWebSocket response data.

		/// </summary>
		public WebSocketFrame Response { get; set; }
	}
}
