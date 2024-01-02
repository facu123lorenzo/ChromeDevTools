using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Key range.

	/// </summary>
	[SupportedBy("iOS")]
	public class KeyRange
	{
		/// <summary>
		/// Gets or setsLower bound.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key Lower { get; set; }
		/// <summary>
		/// Gets or setsUpper bound.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Key Upper { get; set; }
		/// <summary>
		/// Gets or setsIf true lower bound is open.

		/// </summary>
		public bool LowerOpen { get; set; }
		/// <summary>
		/// Gets or setsIf true upper bound is open.

		/// </summary>
		public bool UpperOpen { get; set; }
	}
}
