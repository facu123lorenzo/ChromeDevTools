using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	[SupportedBy("iOS")]
	public class CollectionEntry
	{
		/// <summary>
		/// Gets or setsEntry key of a map-like collection, otherwise not provided.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or setsEntry value.

		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
