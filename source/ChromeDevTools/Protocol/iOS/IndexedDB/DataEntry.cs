using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Data entry.

	/// </summary>
	[SupportedBy("iOS")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or setsKey.

		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or setsPrimary key.

		/// </summary>
		public Runtime.RemoteObject PrimaryKey { get; set; }
		/// <summary>
		/// Gets or setsValue.

		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
