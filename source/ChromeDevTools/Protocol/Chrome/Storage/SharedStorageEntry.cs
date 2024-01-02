using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Struct for a single key-value pair in an origin's shared storage.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SharedStorageEntry
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Value { get; set; }
	}
}
