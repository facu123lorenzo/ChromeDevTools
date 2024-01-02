using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when request for resources within a .wbn file failed.

	/// </summary>
	[Event(ProtocolName.Network.SubresourceWebBundleInnerResponseError)]
	[SupportedBy("Chrome")]
	public class SubresourceWebBundleInnerResponseErrorEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier of the subresource request

		/// </summary>
		public string InnerRequestId { get; set; }
		/// <summary>
		/// Gets or setsURL of the subresource resource.

		/// </summary>
		public string InnerRequestURL { get; set; }
		/// <summary>
		/// Gets or setsError message

		/// </summary>
		public string ErrorMessage { get; set; }
		/// <summary>
		/// Gets or setsBundle request identifier. Used to match this information to another event.
		/// This made be absent in case when the instrumentation was enabled only
		/// after webbundle was parsed.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BundleRequestId { get; set; }
	}
}
