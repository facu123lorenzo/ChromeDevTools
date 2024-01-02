using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///The origin's IndexedDB database list has been modified.

	/// </summary>
	[Event(ProtocolName.Storage.IndexedDBListUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBListUpdatedEvent
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
	}
}
