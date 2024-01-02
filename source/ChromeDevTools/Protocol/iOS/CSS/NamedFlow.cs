using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///This object represents a Named Flow.

	/// </summary>
	[SupportedBy("iOS")]
	public class NamedFlow
	{
		/// <summary>
		/// Gets or setsThe document node id.

		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or setsNamed Flow identifier.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsThe "overset" attribute of a Named Flow.

		/// </summary>
		public bool Overset { get; set; }
		/// <summary>
		/// Gets or setsAn array of nodes that flow into the Named Flow.

		/// </summary>
		public long[] Content { get; set; }
		/// <summary>
		/// Gets or setsAn array of regions associated with the Named Flow.

		/// </summary>
		public Region[] Regions { get; set; }
	}
}
