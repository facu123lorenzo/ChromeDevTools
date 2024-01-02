using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///Fired when HTTP request has been served from memory cache.

	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromMemoryCache)]
	[SupportedBy("iOS")]
	public class RequestServedFromMemoryCacheEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsFrame identifier.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsLoader identifier.

		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or setsURL of the document this request is loaded for.

		/// </summary>
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsRequest initiator.

		/// </summary>
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or setsCached resource data.

		/// </summary>
		public CachedResource Resource { get; set; }
	}
}
