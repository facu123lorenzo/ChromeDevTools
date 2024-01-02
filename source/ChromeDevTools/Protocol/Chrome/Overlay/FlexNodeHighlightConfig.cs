using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class FlexNodeHighlightConfig
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance of flex containers.

		/// </summary>
		public FlexContainerHighlightConfig FlexContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the node to highlight.

		/// </summary>
		public long NodeId { get; set; }
	}
}
