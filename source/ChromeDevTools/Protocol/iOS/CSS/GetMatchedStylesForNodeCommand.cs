using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///Returns requested styles for a DOM node identified by <code>nodeId</code>.

	/// </summary>
	[Command(ProtocolName.CSS.GetMatchedStylesForNode)]
	[SupportedBy("iOS")]
	public class GetMatchedStylesForNodeCommand: ICommand<GetMatchedStylesForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsWhether to include pseudo styles (default: true).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludePseudo { get; set; }
		/// <summary>
		/// Gets or setsWhether to include inherited styles (default: true).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeInherited { get; set; }
	}
}
