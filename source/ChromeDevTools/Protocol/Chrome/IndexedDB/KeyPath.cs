using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	///Key path.

	/// </summary>
	[SupportedBy("Chrome")]
	public class KeyPath
	{
		/// <summary>
		/// Gets or setsKey path type.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsString value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Gets or setsArray value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] Array { get; set; }
	}
}
