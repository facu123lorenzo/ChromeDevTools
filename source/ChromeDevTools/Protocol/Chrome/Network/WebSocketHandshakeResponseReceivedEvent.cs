using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when WebSocket handshake response becomes available.

	/// </summary>
	[Event(ProtocolName.Network.WebSocketHandshakeResponseReceived)]
	[SupportedBy("Chrome")]
	public class WebSocketHandshakeResponseReceivedEvent
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
		public WebSocketResponse Response { get; set; }
	}
}
