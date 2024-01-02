using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Returns attributes for the specified node.

	/// </summary>
	[Command(ProtocolName.DOM.GetAttributes)]
	[SupportedBy("Chrome")]
	public class GetAttributesCommand: ICommand<GetAttributesCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the node to retrieve attibutes for.

		/// </summary>
		public long NodeId { get; set; }
	}
}
