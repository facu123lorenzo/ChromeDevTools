using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Location in the source code.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Location
	{
		/// <summary>
		/// Gets or setsScript identifier as reported in the `Debugger.scriptParsed`.

		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or setsLine number in the script (0-based).

		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or setsColumn number in the script (0-based).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
	}
}
