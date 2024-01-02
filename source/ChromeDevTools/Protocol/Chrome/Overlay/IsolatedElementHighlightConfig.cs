using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class IsolatedElementHighlightConfig
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance of an element in isolation mode.

		/// </summary>
		public IsolationModeHighlightConfig IsolationModeHighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the isolated element to highlight.

		/// </summary>
		public long NodeId { get; set; }
	}
}
