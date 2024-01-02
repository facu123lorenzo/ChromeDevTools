using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Sets attribute for an element with given id.

	/// </summary>
	[Command(ProtocolName.DOM.SetAttributeValue)]
	[SupportedBy("iOS")]
	public class SetAttributeValueCommand: ICommand<SetAttributeValueCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the element to set attribute for.

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
