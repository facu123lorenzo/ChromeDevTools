using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Executes `querySelectorAll` on a given node.

	/// </summary>
	[Command(ProtocolName.DOM.QuerySelectorAll)]
	[SupportedBy("Chrome")]
	public class QuerySelectorAllCommand: ICommand<QuerySelectorAllCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the node to query upon.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsSelector string.

		/// </summary>
		public string Selector { get; set; }
	}
}
