using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Called when a pseudo element is removed from an element.

	/// </summary>
	[Event(ProtocolName.DOM.PseudoElementRemoved)]
	[SupportedBy("iOS")]
	public class PseudoElementRemovedEvent
	{
		/// <summary>
		/// Gets or setsPseudo element's parent element id.

		/// </summary>
		public long ParentId { get; set; }
		/// <summary>
		/// Gets or setsThe removed pseudo element id.

		/// </summary>
		public long PseudoElementId { get; set; }
	}
}
