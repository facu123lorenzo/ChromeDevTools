using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ContainerQueryHighlightConfig
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance of container query containers.

		/// </summary>
		public ContainerQueryContainerHighlightConfig ContainerQueryContainerHighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the container node to highlight.

		/// </summary>
		public long NodeId { get; set; }
	}
}
