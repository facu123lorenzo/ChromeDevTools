using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Response to an AuthChallenge.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AuthChallengeResponse
	{
		/// <summary>
		/// Gets or setsThe decision on what to do in response to the authorization challenge.  Default means
		/// deferring to the default behavior of the net stack, which will likely either the Cancel
		/// authentication or display a popup dialog box.

		/// </summary>
		public string Response { get; set; }
		/// <summary>
		/// Gets or setsThe username to provide, possibly empty. Should only be set if response is
		/// ProvideCredentials.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Username { get; set; }
		/// <summary>
		/// Gets or setsThe password to provide, possibly empty. Should only be set if response is
		/// ProvideCredentials.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Password { get; set; }
	}
}
