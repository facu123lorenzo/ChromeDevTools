using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	///Delete a range of entries from an object store

	/// </summary>
	[Command(ProtocolName.IndexedDB.DeleteObjectStoreEntries)]
	[SupportedBy("Chrome")]
	public class DeleteObjectStoreEntriesCommand: ICommand<DeleteObjectStoreEntriesCommandResponse>
	{
		/// <summary>
		/// Gets or setsAt least and at most one of securityOrigin, storageKey, or storageBucket must be specified.
		/// Security origin.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or setsStorage key.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or setsStorage bucket. If not specified, it uses the default bucket.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Storage.StorageBucket StorageBucket { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or setsRange of entry keys to delete

		/// </summary>
		public KeyRange KeyRange { get; set; }
	}
}
