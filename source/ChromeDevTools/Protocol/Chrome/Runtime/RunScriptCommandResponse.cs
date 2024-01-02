using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Runs script with given id in a given context.

	/// </summary>
	[CommandResponse(ProtocolName.Runtime.RunScript)]
	[SupportedBy("Chrome")]
	public class RunScriptCommandResponse
	{
		/// <summary>
		/// Gets or setsRun result.

		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or setsException details.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
