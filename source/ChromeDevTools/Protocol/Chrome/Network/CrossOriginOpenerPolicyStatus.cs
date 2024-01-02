using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class CrossOriginOpenerPolicyStatus
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public CrossOriginOpenerPolicyValue Value { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public CrossOriginOpenerPolicyValue ReportOnlyValue { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportingEndpoint { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ReportOnlyReportingEndpoint { get; set; }
	}
}
