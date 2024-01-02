using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	///Fetches the root node.
	/// Requires `enable()` to have been called previously.

	/// </summary>
	[Command(ProtocolName.Accessibility.GetRootAXNode)]
	[SupportedBy("Chrome")]
	public class GetRootAXNodeCommand: ICommand<GetRootAXNodeCommandResponse>
	{
		/// <summary>
		/// Gets or setsThe frame in whose document the node resides.
		/// If omitted, the root frame is used.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
	}
}
