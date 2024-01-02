using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	///Returns content of the given resource.

	/// </summary>
	[CommandResponse(ProtocolName.Page.GetResourceContent)]
	[SupportedBy("iOS")]
	public class GetResourceContentCommandResponse
	{
		/// <summary>
		/// Gets or setsResource content.

		/// </summary>
		public string Content { get; set; }
		/// <summary>
		/// Gets or setsTrue, if content was served as base64.

		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}
