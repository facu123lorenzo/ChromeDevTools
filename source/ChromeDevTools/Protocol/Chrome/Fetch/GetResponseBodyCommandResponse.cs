using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	///Causes the body of the response to be received from the server and
	/// returned as a single string. May only be issued for a request that
	/// is paused in the Response stage and is mutually exclusive with
	/// takeResponseBodyForInterceptionAsStream. Calling other methods that
	/// affect the request or disabling fetch domain before body is received
	/// results in an undefined behavior.
	/// Note that the response body is not available for redirects. Requests
	/// paused in the _redirect received_ state may be differentiated by
	/// `responseCode` and presence of `location` response header, see
	/// comments to `requestPaused` for details.

	/// </summary>
	[CommandResponse(ProtocolName.Fetch.GetResponseBody)]
	[SupportedBy("Chrome")]
	public class GetResponseBodyCommandResponse
	{
		/// <summary>
		/// Gets or setsResponse body.

		/// </summary>
		public string Body { get; set; }
		/// <summary>
		/// Gets or setsTrue, if content was sent as base64.

		/// </summary>
		public bool Base64Encoded { get; set; }
	}
}
