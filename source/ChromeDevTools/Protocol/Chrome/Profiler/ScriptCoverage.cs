using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Profiler
{
	/// <summary>
	///Coverage data for a JavaScript script.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ScriptCoverage
	{
		/// <summary>
		/// Gets or setsJavaScript script id.

		/// </summary>
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or setsJavaScript script name or url.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsFunctions contained in the script that has coverage data.

		/// </summary>
		public FunctionCoverage[] Functions { get; set; }
	}
}
