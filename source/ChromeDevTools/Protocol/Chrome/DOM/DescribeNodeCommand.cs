using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Describes node given its id, does not require domain to be enabled. Does not start tracking any
	/// objects, can be used for automation.

	/// </summary>
	[Command(ProtocolName.DOM.DescribeNode)]
	[SupportedBy("Chrome")]
	public class DescribeNodeCommand: ICommand<DescribeNodeCommandResponse>
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
		/// <summary>
		/// Gets or setsThe maximum depth at which children should be retrieved, defaults to 1. Use -1 for the
		/// entire subtree or provide an integer larger than 0.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Depth { get; set; }
		/// <summary>
		/// Gets or setsWhether or not iframes and shadow roots should be traversed when returning the subtree
		/// (default is false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Pierce { get; set; }
	}
}
