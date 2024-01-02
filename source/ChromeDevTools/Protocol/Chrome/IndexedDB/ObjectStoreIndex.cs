using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	///Object store index.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ObjectStoreIndex
	{
		/// <summary>
		/// Gets or setsIndex name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsIndex key path.

		/// </summary>
		public KeyPath KeyPath { get; set; }
		/// <summary>
		/// Gets or setsIf true, index is unique.

		/// </summary>
		public bool Unique { get; set; }
		/// <summary>
		/// Gets or setsIf true, index allows multiple entries for a key.

		/// </summary>
		public bool MultiEntry { get; set; }
	}
}
