using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Evaluates expression on a given call frame.

	/// </summary>
	[CommandResponse(ProtocolName.Debugger.EvaluateOnCallFrame)]
	[SupportedBy("Chrome")]
	public class EvaluateOnCallFrameCommandResponse
	{
		/// <summary>
		/// Gets or setsObject wrapper for the evaluation result.

		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or setsException details.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.ExceptionDetails ExceptionDetails { get; set; }
	}
}
