using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Highlights all DOM nodes that match a given selector. A string containing a CSS selector must be specified.

	/// </summary>
	[Command(ProtocolName.DOM.HighlightSelector)]
	[SupportedBy("iOS")]
	public class HighlightSelectorCommand: ICommand<HighlightSelectorCommandResponse>
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance.

		/// </summary>
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsA CSS selector for finding matching nodes to highlight.

		/// </summary>
		public string SelectorString { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the frame which will be searched using the selector.  If not provided, the main frame will be used.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
