using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when data chunk was received over the network.

	/// </summary>
	[Event(ProtocolName.Network.DataReceived)]
	[SupportedBy("Chrome")]
	public class DataReceivedEvent
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
		/// Gets or setsData chunk length.

		/// </summary>
		public long DataLength { get; set; }
		/// <summary>
		/// Gets or setsActual bytes received (might be less than dataLength for compressed encodings).

		/// </summary>
		public long EncodedDataLength { get; set; }
		/// <summary>
		/// Gets or setsData that was received. (Encoded as a base64 string when passed over JSON)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Data { get; set; }
	}
}
