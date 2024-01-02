using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.OverlayTypes
{
	/// <summary>
	///Data required to highlight a DOM node.

	/// </summary>
	[SupportedBy("iOS")]
	public class NodeHighlightData
	{
		/// <summary>
		/// Gets or setsScroll offset for the MainFrame's FrameView that is shared across all quads.

		/// </summary>
		public Point ScrollOffset { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public FragmentHighlightData[] Fragments { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ElementData ElementData { get; set; }
	}
}
