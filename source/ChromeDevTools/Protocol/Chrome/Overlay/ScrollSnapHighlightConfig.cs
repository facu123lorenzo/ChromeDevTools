using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ScrollSnapHighlightConfig
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance of scroll snap containers.

		/// </summary>
		public ScrollSnapContainerHighlightConfig ScrollSnapContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the node to highlight.

		/// </summary>
		public long NodeId { get; set; }
	}
}
