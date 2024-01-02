using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Bundles the parameters for shared storage access events whose
	/// presence/absence can vary according to SharedStorageAccessType.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageAccessParams
	{
		/// <summary>
		/// Gets or setsSpec of the module script URL.
		/// Present only for SharedStorageAccessType.documentAddModule.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ScriptSourceUrl { get; set; }
		/// <summary>
		/// Gets or setsName of the registered operation to be run.
		/// Present only for SharedStorageAccessType.documentRun and
		/// SharedStorageAccessType.documentSelectURL.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string OperationName { get; set; }
		/// <summary>
		/// Gets or setsThe operation's serialized data in bytes (converted to a string).
		/// Present only for SharedStorageAccessType.documentRun and
		/// SharedStorageAccessType.documentSelectURL.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SerializedData { get; set; }
		/// <summary>
		/// Gets or setsArray of candidate URLs' specs, along with any associated metadata.
		/// Present only for SharedStorageAccessType.documentSelectURL.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SharedStorageUrlWithMetadata[] UrlsWithMetadata { get; set; }
		/// <summary>
		/// Gets or setsKey for a specific entry in an origin's shared storage.
		/// Present only for SharedStorageAccessType.documentSet,
		/// SharedStorageAccessType.documentAppend,
		/// SharedStorageAccessType.documentDelete,
		/// SharedStorageAccessType.workletSet,
		/// SharedStorageAccessType.workletAppend,
		/// SharedStorageAccessType.workletDelete, and
		/// SharedStorageAccessType.workletGet.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Key { get; set; }
		/// <summary>
		/// Gets or setsValue for a specific entry in an origin's shared storage.
		/// Present only for SharedStorageAccessType.documentSet,
		/// SharedStorageAccessType.documentAppend,
		/// SharedStorageAccessType.workletSet, and
		/// SharedStorageAccessType.workletAppend.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsWhether or not to set an entry for a key if that key is already present.
		/// Present only for SharedStorageAccessType.documentSet and
		/// SharedStorageAccessType.workletSet.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnoreIfPresent { get; set; }
	}
}
