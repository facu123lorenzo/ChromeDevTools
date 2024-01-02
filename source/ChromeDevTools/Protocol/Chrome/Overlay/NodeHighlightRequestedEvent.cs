using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Fired when the node should be highlighted. This happens after call to `setInspectMode`.

	/// </summary>
	[Event(ProtocolName.Overlay.NodeHighlightRequested)]
	[SupportedBy("Chrome")]
	public class NodeHighlightRequestedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long NodeId { get; set; }
	}
}
