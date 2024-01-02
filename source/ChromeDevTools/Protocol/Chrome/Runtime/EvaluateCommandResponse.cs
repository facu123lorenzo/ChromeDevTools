using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Evaluates expression on global object.

	/// </summary>
	[CommandResponse(ProtocolName.Runtime.Evaluate)]
	[SupportedBy("Chrome")]
	public class EvaluateCommandResponse
	{
		/// <summary>
		/// Gets or setsEvaluation result.

		/// </summary>
		public RemoteObject Result { get; set; }
		/// <summary>
		/// Gets or setsException details.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ExceptionDetails ExceptionDetails { get; set; }
	}
}
