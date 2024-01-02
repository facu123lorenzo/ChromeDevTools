using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	/// <summary>
	///Database object.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Database
	{
		/// <summary>
		/// Gets or setsDatabase ID.

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or setsDatabase domain.

		/// </summary>
		public string Domain { get; set; }
		/// <summary>
		/// Gets or setsDatabase name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsDatabase version.

		/// </summary>
		public string Version { get; set; }
	}
}
