using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Returns content served for the given request.

	/// </summary>
	[CommandResponse(ProtocolName.Network.GetResponseBody)]
	[SupportedBy("Chrome")]
	public class GetResponseBodyCommandResponse
	{
		/// <summary>
		/// Gets or setsResponse body.

		/// </summary>
		public string Body { get; set; }
		/// <summary>
		/// Gets or setsTrue, if content was sent as base64.

		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}
