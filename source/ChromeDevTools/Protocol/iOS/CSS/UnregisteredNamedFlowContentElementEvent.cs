using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///Fires when a Named Flow's has been registered with a new content node.

	/// </summary>
	[Event(ProtocolName.CSS.UnregisteredNamedFlowContentElement)]
	[SupportedBy("iOS")]
	public class UnregisteredNamedFlowContentElementEvent
	{
		/// <summary>
		/// Gets or setsThe document node id.

		/// </summary>
		public long DocumentNodeId { get; set; }
		/// <summary>
		/// Gets or setsNamed Flow identifier for which the new content element was unregistered.

		/// </summary>
		public string FlowName { get; set; }
		/// <summary>
		/// Gets or setsThe node id of the unregistered content node.

		/// </summary>
		public long ContentNodeId { get; set; }
	}
}
