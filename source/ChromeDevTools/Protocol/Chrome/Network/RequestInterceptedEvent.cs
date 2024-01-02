using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Details of an intercepted HTTP request, which must be either allowed, blocked, modified or
	/// mocked.
	/// Deprecated, use Fetch.requestPaused instead.

	/// </summary>
	[Event(ProtocolName.Network.RequestIntercepted)]
	[SupportedBy("Chrome")]
	public class RequestInterceptedEvent
	{
		/// <summary>
		/// Gets or setsEach request the page makes will have a unique id, however if any redirects are encountered
		/// while processing that fetch, they will be reported with the same id as the original fetch.
		/// Likewise if HTTP authentication is needed then the same fetch id will be used.

		/// </summary>
		public string InterceptionId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Request Request { get; set; }
		/// <summary>
		/// Gets or setsThe id of the frame that initiated the request.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsHow the requested resource will be used.

		/// </summary>
		public ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or setsWhether this is a navigation request, which can abort the navigation completely.

		/// </summary>
		public bool IsNavigationRequest { get; set; }
		/// <summary>
		/// Gets or setsSet if the request is a navigation that will result in a download.
		/// Only present after response is received from the server (i.e. HeadersReceived stage).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsDownload { get; set; }
		/// <summary>
		/// Gets or setsRedirect location, only sent if a redirect was intercepted.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RedirectUrl { get; set; }
		/// <summary>
		/// Gets or setsDetails of the Authorization Challenge encountered. If this is set then
		/// continueInterceptedRequest must contain an authChallengeResponse.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AuthChallenge AuthChallenge { get; set; }
		/// <summary>
		/// Gets or setsResponse error if intercepted at response stage or if redirect occurred while intercepting
		/// request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ErrorReason ResponseErrorReason { get; set; }
		/// <summary>
		/// Gets or setsResponse code if intercepted at response stage or if redirect occurred while intercepting
		/// request or auth retry occurred.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ResponseStatusCode { get; set; }
		/// <summary>
		/// Gets or setsResponse headers if intercepted at the response stage or if redirect occurred while
		/// intercepting request or auth retry occurred.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> ResponseHeaders { get; set; }
		/// <summary>
		/// Gets or setsIf the intercepted request had a corresponding requestWillBeSent event fired for it, then
		/// this requestId will be the same as the requestId present in the requestWillBeSent event.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
	}
}
