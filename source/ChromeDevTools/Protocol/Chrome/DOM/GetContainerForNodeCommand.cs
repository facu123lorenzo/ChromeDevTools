using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOM
{
	/// <summary>
	///Returns the query container of the given node based on container query
	/// conditions: containerName, physical, and logical axes. If no axes are
	/// provided, the style container is returned, which is the direct parent or the
	/// closest element with a matching container-name.

	/// </summary>
	[Command(ProtocolName.DOM.GetContainerForNode)]
	[SupportedBy("Chrome")]
	public class GetContainerForNodeCommand: ICommand<GetContainerForNodeCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ContainerName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PhysicalAxes { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string LogicalAxes { get; set; }
	}
}
