using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Evaluates given script in every frame upon creation (before loading frame's scripts).

	/// </summary>
	[Command(ProtocolName.Page.AddScriptToEvaluateOnNewDocument)]
	[SupportedBy("Chrome")]
	public class AddScriptToEvaluateOnNewDocumentCommand: ICommand<AddScriptToEvaluateOnNewDocumentCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Source { get; set; }
		/// <summary>
		/// Gets or setsIf specified, creates an isolated world with the given name and evaluates given script in it.
		/// This world name will be used as the ExecutionContextDescription::name when the corresponding
		/// event is emitted.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string WorldName { get; set; }
		/// <summary>
		/// Gets or setsSpecifies whether command line API should be available to the script, defaults
		/// to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeCommandLineAPI { get; set; }
		/// <summary>
		/// Gets or setsIf true, runs the script immediately on existing execution contexts or worlds.
		/// Default: false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? RunImmediately { get; set; }
	}
}
