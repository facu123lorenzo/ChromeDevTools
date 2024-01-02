using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	[SupportedBy("iOS")]
	public class EntryPreview
	{
		/// <summary>
		/// Gets or setsEntry key. Specified for map-like collection entries.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview Key { get; set; }
		/// <summary>
		/// Gets or setsEntry value.

		/// </summary>
		public ObjectPreview Value { get; set; }
	}
}
