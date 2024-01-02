using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Fired when <code>Element</code>'s attribute is removed.

	/// </summary>
	[Event(ProtocolName.DOM.AttributeRemoved)]
	[SupportedBy("iOS")]
	public class AttributeRemovedEvent
	{
		/// <summary>
		/// Gets or setsId of the node that has changed.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsA ttribute name.

		/// </summary>
		public string Name { get; set; }
	}
}
