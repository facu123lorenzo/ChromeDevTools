using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when WebSocket message error occurs.

	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameError)]
	[SupportedBy("Chrome")]
	public class WebSocketFrameErrorEvent
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
		/// Gets or setsWebSocket error message.

		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
