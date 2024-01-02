using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///Fired when WebSocket is about to initiate handshake.

	/// </summary>
	[Event(ProtocolName.Network.WebSocketWillSendHandshakeRequest)]
	[SupportedBy("iOS")]
	public class WebSocketWillSendHandshakeRequestEvent
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
		/// Gets or setsWebSocket request data.

		/// </summary>
		public WebSocketRequest Request { get; set; }
	}
}
