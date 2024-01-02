using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Highlights DOM node with given id or with the given JavaScript object wrapper. Either nodeId or
	/// objectId must be specified.

	/// </summary>
	[Command(ProtocolName.Overlay.HighlightNode)]
	[SupportedBy("Chrome")]
	public class HighlightNodeCommand: ICommand<HighlightNodeCommandResponse>
	{
		/// <summary>
		/// Gets or setsA descriptor for the highlight appearance.

		/// </summary>
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the node to highlight.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the backend node to highlight.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or setsJavaScript object id of the node to be highlighted.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsSelectors to highlight relevant nodes.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Selector { get; set; }
	}
}
