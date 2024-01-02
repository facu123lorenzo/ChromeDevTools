using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Schema
{
	/// <summary>
	///Description of the protocol domain.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Domain
	{
		/// <summary>
		/// Gets or setsDomain name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsDomain version.

		/// </summary>
		public string Version { get; set; }
	}
}
