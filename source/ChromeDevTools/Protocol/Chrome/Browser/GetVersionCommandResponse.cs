using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Returns version information.

	/// </summary>
	[CommandResponse(ProtocolName.Browser.GetVersion)]
	[SupportedBy("Chrome")]
	public class GetVersionCommandResponse
	{
		/// <summary>
		/// Gets or setsProtocol version.

		/// </summary>
		public string ProtocolVersion { get; set; }
		/// <summary>
		/// Gets or setsProduct name.

		/// </summary>
		public string Product { get; set; }
		/// <summary>
		/// Gets or setsProduct revision.

		/// </summary>
		public string Revision { get; set; }
		/// <summary>
		/// Gets or setsUser-Agent.

		/// </summary>
		public string UserAgent { get; set; }
		/// <summary>
		/// Gets or setsV8 version.

		/// </summary>
		public string JsVersion { get; set; }
	}
}
