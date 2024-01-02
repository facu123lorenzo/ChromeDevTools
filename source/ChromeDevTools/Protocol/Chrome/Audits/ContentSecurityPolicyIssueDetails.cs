using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	[SupportedBy("Chrome")]
	public class ContentSecurityPolicyIssueDetails
	{
		/// <summary>
		/// Gets or setsThe url not included in allowed sources.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BlockedURL { get; set; }
		/// <summary>
		/// Gets or setsSpecific directive that is violated, causing the CSP issue.

		/// </summary>
		public string ViolatedDirective { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool IsReportOnly { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ContentSecurityPolicyViolationType ContentSecurityPolicyViolationType { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AffectedFrame FrameAncestor { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ViolatingNodeId { get; set; }
	}
}
