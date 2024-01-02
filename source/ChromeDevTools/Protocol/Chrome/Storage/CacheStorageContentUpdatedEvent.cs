using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///A cache's contents have been modified.

	/// </summary>
	[Event(ProtocolName.Storage.CacheStorageContentUpdated)]
	[SupportedBy("Chrome")]
	public class CacheStorageContentUpdatedEvent
	{
		/// <summary>
		/// Gets or setsOrigin to update.

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or setsStorage key to update.

		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or setsStorage bucket to update.

		/// </summary>
		public string BucketId { get; set; }
		/// <summary>
		/// Gets or setsName of cache in origin.

		/// </summary>
		public string CacheName { get; set; }
	}
}
