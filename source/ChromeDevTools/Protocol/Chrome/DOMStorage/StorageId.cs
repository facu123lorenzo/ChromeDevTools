using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	/// <summary>
	///DOM Storage identifier.

	/// </summary>
	[SupportedBy("Chrome")]
	public class StorageId
	{
		/// <summary>
		/// Gets or setsSecurity origin for the storage.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or setsRepresents a key by which DOM Storage keys its CachedStorageAreas

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or setsWhether the storage is local storage (not session storage).

		/// </summary>
		public bool IsLocalStorage { get; set; }
	}
}
