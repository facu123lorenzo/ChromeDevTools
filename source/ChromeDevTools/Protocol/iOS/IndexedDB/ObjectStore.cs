using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Object store.

	/// </summary>
	[SupportedBy("iOS")]
	public class ObjectStore
	{
		/// <summary>
		/// Gets or setsObject store name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsObject store key path.

		/// </summary>
		public KeyPath KeyPath { get; set; }
		/// <summary>
		/// Gets or setsIf true, object store has auto increment flag set.

		/// </summary>
		public bool AutoIncrement { get; set; }
		/// <summary>
		/// Gets or setsIndexes in this object store.

		/// </summary>
		public ObjectStoreIndex[] Indexes { get; set; }
	}
}
