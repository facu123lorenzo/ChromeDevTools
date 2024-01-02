using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	///Returns source for the script with given id.

	/// </summary>
	[Command(ProtocolName.Debugger.GetScriptSource)]
	[SupportedBy("iOS")]
	public class GetScriptSourceCommand: ICommand<GetScriptSourceCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the script to get source for.

		/// </summary>
		public string ScriptId { get; set; }
	}
}
