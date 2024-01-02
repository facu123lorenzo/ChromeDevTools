using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Key.

	/// </summary>
	[SupportedBy("iOS")]
	public class Key
	{
		/// <summary>
		/// Gets or setsKey type.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsNumber value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Number { get; set; }
		/// <summary>
		/// Gets or setsString value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string String { get; set; }
		/// <summary>
		/// Gets or setsDate value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Date { get; set; }
		/// <summary>
		/// Gets or setsArray value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key[] Array { get; set; }
	}
}
