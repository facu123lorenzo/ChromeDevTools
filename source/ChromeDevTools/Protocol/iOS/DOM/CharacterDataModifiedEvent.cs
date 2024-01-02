using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Mirrors <code>DOMCharacterDataModified</code> event.

	/// </summary>
	[Event(ProtocolName.DOM.CharacterDataModified)]
	[SupportedBy("iOS")]
	public class CharacterDataModifiedEvent
	{
		/// <summary>
		/// Gets or setsId of the node that has changed.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsNew text value.

		/// </summary>
		public string CharacterData { get; set; }
	}
}
