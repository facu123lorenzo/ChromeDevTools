using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Fetch
{
	[SupportedBy("Chrome")]
	public class RequestPattern
	{
		/// <summary>
		/// Gets or setsWildcards (`'*'` -> zero or more, `'?'` -> exactly one) are allowed. Escape character is
		/// backslash. Omitting is equivalent to `"*"`.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UrlPattern { get; set; }
		/// <summary>
		/// Gets or setsIf set, only requests for matching resource types will be intercepted.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ResourceType ResourceType { get; set; }
		/// <summary>
		/// Gets or setsStage at which to begin intercepting requests. Default is Request.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RequestStage RequestStage { get; set; }
	}
}
