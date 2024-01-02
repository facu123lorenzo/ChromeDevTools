using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Compiles expression.

	/// </summary>
	[CommandResponse(ProtocolName.Runtime.CompileScript)]
	[SupportedBy("Chrome")]
	public class CompileScriptCommandResponse
	{
		/// <summary>
		/// Gets or setsId of the script.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or setsException details.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
