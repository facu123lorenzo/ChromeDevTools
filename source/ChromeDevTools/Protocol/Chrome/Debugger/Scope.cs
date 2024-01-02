using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Scope description.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Scope
	{
		/// <summary>
		/// Gets or setsScope type.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsObject representing the scope. For `global` and `with` scopes it represents the actual
		/// object; for the rest of the scopes, it is artificial transient object enumerating scope
		/// variables as its properties.

		/// </summary>
		public Runtime.RemoteObject Object { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsLocation in the source code where scope starts

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location StartLocation { get; set; }
		/// <summary>
		/// Gets or setsLocation in the source code where scope ends

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location EndLocation { get; set; }
	}
}
