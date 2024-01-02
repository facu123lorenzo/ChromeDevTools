using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired upon WebTransport creation.

	/// </summary>
	[Event(ProtocolName.Network.WebTransportCreated)]
	[SupportedBy("Chrome")]
	public class WebTransportCreatedEvent
	{
		/// <summary>
		/// Gets or setsWebTransport identifier.

		/// </summary>
		public string TransportId { get; set; }
		/// <summary>
		/// Gets or setsWebTransport request URL.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsRequest initiator.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Initiator Initiator { get; set; }
	}
}
