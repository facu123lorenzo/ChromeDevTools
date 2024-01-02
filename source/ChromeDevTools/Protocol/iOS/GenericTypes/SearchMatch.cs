using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.GenericTypes
{
	/// <summary>
	///Search match in a resource.

	/// </summary>
	[SupportedBy("iOS")]
	public class SearchMatch
	{
		/// <summary>
		/// Gets or setsLine number in resource content.

		/// </summary>
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or setsLine with match content.

		/// </summary>
		public string LineContent { get; set; }
	}
}
