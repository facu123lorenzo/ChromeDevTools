using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CacheStorage
{
	/// <summary>
	///Requests cache names.

	/// </summary>
	[Command(ProtocolName.CacheStorage.RequestCacheNames)]
	[SupportedBy("Chrome")]
	public class RequestCacheNamesCommand: ICommand<RequestCacheNamesCommandResponse>
	{
		/// <summary>
		/// Gets or setsAt least and at most one of securityOrigin, storageKey, storageBucket must be specified.
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
	}
}
