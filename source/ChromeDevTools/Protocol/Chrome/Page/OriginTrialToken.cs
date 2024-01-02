using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[SupportedBy("Chrome")]
	public class OriginTrialToken
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool MatchSubDomains { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string TrialName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double ExpiryTime { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool IsThirdParty { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public OriginTrialUsageRestriction UsageRestriction { get; set; }
	}
}
