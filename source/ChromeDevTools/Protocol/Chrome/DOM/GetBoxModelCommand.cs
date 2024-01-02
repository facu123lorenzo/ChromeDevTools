using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Returns boxes for the given node.

	/// </summary>
	[Command(ProtocolName.DOM.GetBoxModel)]
	[SupportedBy("Chrome")]
	public class GetBoxModelCommand: ICommand<GetBoxModelCommandResponse>
	{
		/// <summary>
		/// Gets or setsIdentifier of the node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
		/// <summary>
		/// Gets or setsIdentifier of the backend node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or setsJavaScript object id of the node wrapper.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
	}
}
