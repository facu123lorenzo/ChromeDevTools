using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Fired when <code>Element</code>'s attribute is modified.

	/// </summary>
	[Event(ProtocolName.DOM.AttributeModified)]
	[SupportedBy("iOS")]
	public class AttributeModifiedEvent
	{
		/// <summary>
		/// Gets or setsId of the node that has changed.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsAttribute name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsAttribute value.

		/// </summary>
		public string Value { get; set; }
	}
}
