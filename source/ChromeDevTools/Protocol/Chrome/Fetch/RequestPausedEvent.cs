using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	///Issued when the domain is enabled and the request URL matches the
	/// specified filter. The request is paused until the client responds
	/// with one of continueRequest, failRequest or fulfillRequest.
	/// The stage of the request can be determined by presence of responseErrorReason
	/// and responseStatusCode -- the request is at the response stage if either
	/// of these fields is present and in the request stage otherwise.
	/// Redirect responses and subsequent requests are reported similarly to regular
	/// responses and requests. Redirect responses may be distinguished by the value
	/// of `responseStatusCode` (which is one of 301, 302, 303, 307, 308) along with
	/// presence of the `location` header. Requests resulting from a redirect will
	/// have `redirectedRequestId` field set.

	/// </summary>
	[Event(ProtocolName.Fetch.RequestPaused)]
	[SupportedBy("Chrome")]
	public class RequestPausedEvent
	{
		/// <summary>
		/// Gets or setsEach request the page makes will have a unique id.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsThe details of the request.

		/// </summary>
		public Network.Request Request { get; set; }
		/// <summary>
		/// Gets or setsThe id of the frame that initiated the request.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsHow the requested resource will be used.

		/// </summary>
		public Network.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or setsResponse error if intercepted at response stage.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ErrorReason ResponseErrorReason { get; set; }
		/// <summary>
		/// Gets or setsResponse code if intercepted at response stage.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ResponseStatusCode { get; set; }
		/// <summary>
		/// Gets or setsResponse status text if intercepted at response stage.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ResponseStatusText { get; set; }
		/// <summary>
		/// Gets or setsResponse headers if intercepted at the response stage.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeaderEntry[] ResponseHeaders { get; set; }
		/// <summary>
		/// Gets or setsIf the intercepted request had a corresponding Network.requestWillBeSent event fired for it,
		/// then this networkId will be the same as the requestId present in the requestWillBeSent event.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetworkId { get; set; }
		/// <summary>
		/// Gets or setsIf the request is due to a redirect response from the server, the id of the request that
		/// has caused the redirect.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RedirectedRequestId { get; set; }
	}
}
