using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Evaluates expression on a given call frame.

	/// </summary>
	[Command(ProtocolName.Debugger.EvaluateOnCallFrame)]
	[SupportedBy("Chrome")]
	public class EvaluateOnCallFrameCommand: ICommand<EvaluateOnCallFrameCommandResponse>
	{
		/// <summary>
		/// Gets or setsCall frame identifier to evaluate on.

		/// </summary>
		public string CallFrameId { get; set; }
		/// <summary>
		/// Gets or setsExpression to evaluate.

		/// </summary>
		public string Expression { get; set; }
		/// <summary>
		/// Gets or setsString object group name to put result into (allows rapid releasing resulting object handles
		/// using `releaseObjectGroup`).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or setsSpecifies whether command line API should be available to the evaluated expression, defaults
		/// to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or setsIn silent mode exceptions thrown during evaluation are not reported and do not pause
		/// execution. Overrides `setPauseOnException` state.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Silent { get; set; }
		/// <summary>
		/// Gets or setsWhether the result is expected to be a JSON object that should be sent by value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ReturnByValue { get; set; }
		/// <summary>
		/// Gets or setsWhether preview should be generated for the result.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GeneratePreview { get; set; }
		/// <summary>
		/// Gets or setsWhether to throw an exception if side effect cannot be ruled out during evaluation.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ThrowOnSideEffect { get; set; }
		/// <summary>
		/// Gets or setsTerminate execution after timing out (number of milliseconds).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timeout { get; set; }
	}
}
