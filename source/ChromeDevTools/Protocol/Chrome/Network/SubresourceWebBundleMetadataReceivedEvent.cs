using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired once when parsing the .wbn file has succeeded.
	/// The event contains the information about the web bundle contents.

	/// </summary>
	[Event(ProtocolName.Network.SubresourceWebBundleMetadataReceived)]
	[SupportedBy("Chrome")]
	public class SubresourceWebBundleMetadataReceivedEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier. Used to match this information to another event.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsA list of URLs of resources in the subresource Web Bundle.

		/// </summary>
		public string[] Urls { get; set; }
	}
}
