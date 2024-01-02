using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Database with an array of object stores.

	/// </summary>
	[SupportedBy("iOS")]
	public class DatabaseWithObjectStores
	{
		/// <summary>
		/// Gets or setsDatabase name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsDatabase version.

		/// </summary>
		public double Version { get; set; }
		/// <summary>
		/// Gets or setsObject stores in this database.

		/// </summary>
		public ObjectStore[] ObjectStores { get; set; }
	}
}
