using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Removes attribute with given name from an element with given id.

	/// </summary>
	[Command(ProtocolName.DOM.RemoveAttribute)]
	[SupportedBy("iOS")]
	public class RemoveAttributeCommand: ICommand<RemoveAttributeCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the element to remove attribute from.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsName of the attribute to remove.

		/// </summary>
		public string Name { get; set; }
	}
}
