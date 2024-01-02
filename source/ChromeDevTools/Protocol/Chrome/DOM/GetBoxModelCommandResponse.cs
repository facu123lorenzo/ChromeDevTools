using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Returns boxes for the given node.

	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetBoxModel)]
	[SupportedBy("Chrome")]
	public class GetBoxModelCommandResponse
	{
		/// <summary>
		/// Gets or setsBox model for the node.

		/// </summary>
		public BoxModel Model { get; set; }
	}
}
