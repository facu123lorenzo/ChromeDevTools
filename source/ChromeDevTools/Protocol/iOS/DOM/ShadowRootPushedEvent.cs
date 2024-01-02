using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Called when shadow root is pushed into the element.

	/// </summary>
	[Event(ProtocolName.DOM.ShadowRootPushed)]
	[SupportedBy("iOS")]
	public class ShadowRootPushedEvent
	{
		/// <summary>
		/// Gets or setsHost element id.

		/// </summary>
		public long HostId { get; set; }
		/// <summary>
		/// Gets or setsShadow root.

		/// </summary>
		public Node Root { get; set; }
	}
}
