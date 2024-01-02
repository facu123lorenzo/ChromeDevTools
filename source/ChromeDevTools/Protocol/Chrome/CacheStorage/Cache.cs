using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	///Cache identifier.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Cache
	{
		/// <summary>
		/// Gets or setsAn opaque unique id of the cache.

		/// </summary>
		public string CacheId { get; set; }
		/// <summary>
		/// Gets or setsSecurity origin of the cache.

		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or setsStorage key of the cache.

		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or setsStorage bucket of the cache.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Storage.StorageBucket StorageBucket { get; set; }
		/// <summary>
		/// Gets or setsThe name of the cache.

		/// </summary>
		public string CacheName { get; set; }
	}
}
