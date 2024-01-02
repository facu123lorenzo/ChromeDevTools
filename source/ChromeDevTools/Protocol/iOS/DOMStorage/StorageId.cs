using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	/// <summary>
	///DOM Storage identifier.

	/// </summary>
	[SupportedBy("iOS")]
	public class StorageId
	{
		/// <summary>
		/// Gets or setsSecurity origin for the storage.

		/// </summary>
		public string SecurityOrigin { get; set; }
		/// <summary>
		/// Gets or setsWhether the storage is local storage (not session storage).

		/// </summary>
		public bool IsLocalStorage { get; set; }
	}
}
