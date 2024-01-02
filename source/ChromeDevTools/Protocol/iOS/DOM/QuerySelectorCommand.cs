using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Executes <code>querySelector</code> on a given node.

	/// </summary>
	[Command(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("iOS")]
	public class QuerySelectorCommand: ICommand<QuerySelectorCommandResponse>
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
