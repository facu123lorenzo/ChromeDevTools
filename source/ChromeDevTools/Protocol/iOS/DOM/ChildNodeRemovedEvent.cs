using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Mirrors <code>DOMNodeRemoved</code> event.

	/// </summary>
	[Event(ProtocolName.DOM.ChildNodeRemoved)]
	[SupportedBy("iOS")]
	public class ChildNodeRemovedEvent
	{
		/// <summary>
		/// Gets or setsParent id.

		/// </summary>
		public long ParentNodeId { get; set; }
		/// <summary>
		/// Gets or setsId of the node that has been removed.

		/// </summary>
		public long NodeId { get; set; }
	}
}
