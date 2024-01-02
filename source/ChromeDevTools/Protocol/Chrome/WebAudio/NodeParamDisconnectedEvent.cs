using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.WebAudio
{
	/// <summary>
	///Notifies that an AudioNode is disconnected to an AudioParam.

	/// </summary>
	[Event(ProtocolName.WebAudio.NodeParamDisconnected)]
	[SupportedBy("Chrome")]
	public class NodeParamDisconnectedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ContextId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string SourceId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DestinationId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double SourceOutputIndex { get; set; }
	}
}
