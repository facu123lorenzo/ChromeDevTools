using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///The origin's IndexedDB object store has been modified.

	/// </summary>
	[Event(ProtocolName.Storage.IndexedDBContentUpdated)]
	[SupportedBy("Chrome")]
	public class IndexedDBContentUpdatedEvent
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
		/// Gets or setsDatabase to update.

		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or setsObjectStore to update.

		/// </summary>
		public string ObjectStoreName { get; set; }
	}
}
