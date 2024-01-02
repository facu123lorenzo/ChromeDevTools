using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Finds nodes with a given computed style in a subtree.

	/// </summary>
	[Command(ProtocolName.DOM.GetNodesForSubtreeByStyle)]
	[SupportedBy("Chrome")]
	public class GetNodesForSubtreeByStyleCommand: ICommand<GetNodesForSubtreeByStyleCommandResponse>
	{
		/// <summary>
		/// Gets or setsNode ID pointing to the root of a subtree.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsThe style to filter nodes by (includes nodes if any of properties matches).

		/// </summary>
		public CSSComputedStyleProperty[] ComputedStyles { get; set; }
		/// <summary>
		/// Gets or setsWhether or not iframes and shadow roots in the same target should be traversed when returning the
		/// results (default is false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Pierce { get; set; }
	}
}
