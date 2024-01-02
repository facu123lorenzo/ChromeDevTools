using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	///Evaluates expression on a given call frame.

	/// </summary>
	[Command(ProtocolName.Debugger.EvaluateOnCallFrame)]
	[SupportedBy("iOS")]
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
		/// Gets or setsString object group name to put result into (allows rapid releasing resulting object handles using <code>releaseObjectGroup</code>).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
		/// <summary>
		/// Gets or setsSpecifies whether command line API should be available to the evaluated expression, defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or setsSpecifies whether evaluation should stop on exceptions and mute console. Overrides setPauseOnException state.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? DoNotPauseOnExceptionsAndMuteConsole { get; set; }
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
		/// Gets or setsWhether the resulting value should be considered for saving in the $n history.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? SaveResult { get; set; }
	}
}
