using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Sets node name for a node with given id.

	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeName)]
	[SupportedBy("iOS")]
	public class SetNodeNameCommandResponse
	{
		/// <summary>
		/// Gets or setsNew node's id.

		/// </summary>
		public long NodeId { get; set; }
	}
}
