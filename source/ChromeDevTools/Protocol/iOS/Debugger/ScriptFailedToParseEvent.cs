using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	///Fired when virtual machine fails to parse the script.

	/// </summary>
	[Event(ProtocolName.Debugger.ScriptFailedToParse)]
	[SupportedBy("iOS")]
	public class ScriptFailedToParseEvent
	{
		/// <summary>
		/// Gets or setsURL of the script that failed to parse.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsSource text of the script that failed to parse.

		/// </summary>
		public string ScriptSource { get; set; }
		/// <summary>
		/// Gets or setsLine offset of the script within the resource.

		/// </summary>
		public long StartLine { get; set; }
		/// <summary>
		/// Gets or setsLine with error.

		/// </summary>
		public long ErrorLine { get; set; }
		/// <summary>
		/// Gets or setsParse error message.

		/// </summary>
		public string ErrorMessage { get; set; }
	}
}
