using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Returns node id at given location. Depending on whether DOM domain is enabled, nodeId is
	/// either returned or not.

	/// </summary>
	[Command(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome")]
	public class GetNodeForLocationCommand: ICommand<GetNodeForLocationCommandResponse>
	{
		/// <summary>
		/// Gets or setsX coordinate.

		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or setsY coordinate.

		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or setsFalse to skip to the nearest non-UA shadow root ancestor (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeUserAgentShadowDOM { get; set; }
		/// <summary>
		/// Gets or setsWhether to ignore pointer-events: none on elements and hit test them.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IgnorePointerEventsNone { get; set; }
	}
}
