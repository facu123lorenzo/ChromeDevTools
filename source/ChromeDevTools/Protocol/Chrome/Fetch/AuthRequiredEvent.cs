using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	/// <summary>
	///Issued when the domain is enabled with handleAuthRequests set to true.
	/// The request is paused until client responds with continueWithAuth.

	/// </summary>
	[Event(ProtocolName.Fetch.AuthRequired)]
	[SupportedBy("Chrome")]
	public class AuthRequiredEvent
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
		/// Gets or setsDetails of the Authorization Challenge encountered.
		/// If this is set, client should respond with continueRequest that
		/// contains AuthChallengeResponse.

		/// </summary>
		public AuthChallenge AuthChallenge { get; set; }
	}
}
