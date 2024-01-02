using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Enables streaming of the response for the given requestId.
	/// If enabled, the dataReceived event contains the data that was received during streaming.

	/// </summary>
	[CommandResponse(ProtocolName.Network.StreamResourceContent)]
	[SupportedBy("Chrome")]
	public class StreamResourceContentCommandResponse
	{
		/// <summary>
		/// Gets or setsData that has been buffered until streaming is enabled. (Encoded as a base64 string when passed over JSON)

		/// </summary>
		public string BufferedData { get; set; }
	}
}
