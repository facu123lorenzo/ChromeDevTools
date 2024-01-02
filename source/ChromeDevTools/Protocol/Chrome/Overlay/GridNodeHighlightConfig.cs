using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Configurations for Persistent Grid Highlight

	/// </summary>
	[SupportedBy("Chrome")]
	public class GridNodeHighlightConfig
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance.

		/// </summary>
		public GridHighlightConfig GridHighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the node to highlight.

		/// </summary>
		public long NodeId { get; set; }
	}
}
