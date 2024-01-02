using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when EventSource message is received.

	/// </summary>
	[Event(ProtocolName.Network.EventSourceMessageReceived)]
	[SupportedBy("Chrome")]
	public class EventSourceMessageReceivedEvent
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
		/// Gets or setsMessage type.

		/// </summary>
		public string EventName { get; set; }
		/// <summary>
		/// Gets or setsMessage identifier.

		/// </summary>
		public string EventId { get; set; }
		/// <summary>
		/// Gets or setsMessage content.

		/// </summary>
		public string Data { get; set; }
	}
}
