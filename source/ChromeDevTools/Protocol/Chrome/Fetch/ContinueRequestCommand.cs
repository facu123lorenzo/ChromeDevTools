using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	///Continues the request, optionally modifying some of its parameters.

	/// </summary>
	[Command(ProtocolName.Fetch.ContinueRequest)]
	[SupportedBy("Chrome")]
	public class ContinueRequestCommand: ICommand<ContinueRequestCommandResponse>
	{
		/// <summary>
		/// Gets or setsAn id the client received in requestPaused event.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsIf set, the request url will be modified in a way that's not observable by page.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsIf set, the request method is overridden.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Method { get; set; }
		/// <summary>
		/// Gets or setsIf set, overrides the post data in the request. (Encoded as a base64 string when passed over JSON)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PostData { get; set; }
		/// <summary>
		/// Gets or setsIf set, overrides the request headers. Note that the overrides do not
		/// extend to subsequent redirect hops, if a redirect happens. Another override
		/// may be applied to a different request produced by a redirect.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeaderEntry[] Headers { get; set; }
		/// <summary>
		/// Gets or setsIf set, overrides response interception behavior for this request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? InterceptResponse { get; set; }
	}
}
