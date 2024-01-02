using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	///Requests data from object store or index.

	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestData)]
	[SupportedBy("Chrome")]
	public class RequestDataCommand: ICommand<RequestDataCommandResponse>
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
		/// Gets or setsDatabase name.

		/// </summary>
		public string DatabaseName { get; set; }
		/// <summary>
		/// Gets or setsObject store name.

		/// </summary>
		public string ObjectStoreName { get; set; }
		/// <summary>
		/// Gets or setsIndex name, empty string for object store data requests.

		/// </summary>
		public string IndexName { get; set; }
		/// <summary>
		/// Gets or setsNumber of records to skip.

		/// </summary>
		public long SkipCount { get; set; }
		/// <summary>
		/// Gets or setsNumber of records to fetch.

		/// </summary>
		public long PageSize { get; set; }
		/// <summary>
		/// Gets or setsKey range.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public KeyRange KeyRange { get; set; }
	}
}
