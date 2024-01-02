using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class BackForwardCacheBlockingDetails
	{
		/// <summary>
		/// Gets or setsUrl of the file where blockage happened. Optional because of tests.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsFunction name where blockage happened. Optional because of anonymous functions and tests.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Function { get; set; }
		/// <summary>
		/// Gets or setsLine number in the script (0-based).

		/// </summary>
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or setsColumn number in the script (0-based).

		/// </summary>
		public long ColumnNumber { get; set; }
	}
}
