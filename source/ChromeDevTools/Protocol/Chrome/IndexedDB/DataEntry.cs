using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	///Data entry.

	/// </summary>
	[SupportedBy("Chrome")]
	public class DataEntry
	{
		/// <summary>
		/// Gets or setsKey object.

		/// </summary>
		public Runtime.RemoteObject Key { get; set; }
		/// <summary>
		/// Gets or setsPrimary key object.

		/// </summary>
		public Runtime.RemoteObject PrimaryKey { get; set; }
		/// <summary>
		/// Gets or setsValue object.

		/// </summary>
		public Runtime.RemoteObject Value { get; set; }
	}
}
