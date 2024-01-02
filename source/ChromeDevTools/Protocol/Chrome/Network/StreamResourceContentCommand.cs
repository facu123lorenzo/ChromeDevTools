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
	[Command(ProtocolName.Network.StreamResourceContent)]
	[SupportedBy("Chrome")]
	public class StreamResourceContentCommand: ICommand<StreamResourceContentCommandResponse>
	{
		/// <summary>
		/// Gets or setsIdentifier of the request to stream.

		/// </summary>
		public string RequestId { get; set; }
	}
}
