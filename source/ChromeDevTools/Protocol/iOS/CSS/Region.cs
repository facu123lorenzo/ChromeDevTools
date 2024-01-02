using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///This object represents a region that flows from a Named Flow.

	/// </summary>
	[SupportedBy("iOS")]
	public class Region
	{
		/// <summary>
		/// Gets or setsThe "overset" attribute of a Named Flow.

		/// </summary>
		public string RegionOverset { get; set; }
		/// <summary>
		/// Gets or setsThe corresponding DOM node id.

		/// </summary>
		public long NodeId { get; set; }
	}
}
