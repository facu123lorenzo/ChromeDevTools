using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class StorageBucket
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or setsIf not specified, it is the default bucket of the storageKey.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
	}
}
