using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Stack entry for runtime errors and assertions.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CallFrame
	{
		/// <summary>
		/// Gets or setsJavaScript function name.

		/// </summary>
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or setsJavaScript script id.

		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or setsJavaScript script name or url.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsJavaScript script line number (0-based).

		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or setsJavaScript script column number (0-based).

		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
