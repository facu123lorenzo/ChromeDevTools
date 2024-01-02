using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Called when a pseudo element is added to an element.

	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementAdded)]
	[SupportedBy("Chrome")]
	public class PseudoElementAddedEvent
	{
		/// <summary>
		/// Gets or setsPseudo element's parent element id.

		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or setsThe added pseudo element.

		/// </summary>
		public Node PseudoElement { get; set; }
	}
}
