using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Removes node with given id.

	/// </summary>
	[Command(ProtocolName.DOM.RemoveNode)]
	[SupportedBy("Chrome")]
	public class RemoveNodeCommand: ICommand<RemoveNodeCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the node to remove.

		/// </summary>
		public long NodeId { get; set; }
	}
}
