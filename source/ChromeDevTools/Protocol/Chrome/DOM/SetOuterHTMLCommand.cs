using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Sets node HTML markup, returns new node id.

	/// </summary>
	[Command(ProtocolName.DOM.SetOuterHTML)]
	[SupportedBy("Chrome")]
	public class SetOuterHTMLCommand: ICommand<SetOuterHTMLCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the node to set markup for.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsOuter HTML markup to set.

		/// </summary>
		public string OuterHTML { get; set; }
	}
}
