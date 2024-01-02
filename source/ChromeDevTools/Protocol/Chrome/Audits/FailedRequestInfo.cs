using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class FailedRequestInfo
	{
		/// <summary>
		/// Gets or setsThe URL that failed to load.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsThe failure message for the failed request.

		/// </summary>
		public string FailureMessage { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
	}
}
