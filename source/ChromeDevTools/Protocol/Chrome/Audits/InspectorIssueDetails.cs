using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///This struct holds a list of optional fields with additional information
	/// specific to the kind of issue. When adding a new issue code, please also
	/// add a new optional field to this type.

	/// </summary>
	[SupportedBy("Chrome")]
	public class InspectorIssueDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieIssueDetails CookieIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public MixedContentIssueDetails MixedContentIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BlockedByResponseIssueDetails BlockedByResponseIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public HeavyAdIssueDetails HeavyAdIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ContentSecurityPolicyIssueDetails ContentSecurityPolicyIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SharedArrayBufferIssueDetails SharedArrayBufferIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LowTextContrastIssueDetails LowTextContrastIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CorsIssueDetails CorsIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AttributionReportingIssueDetails AttributionReportingIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public QuirksModeIssueDetails QuirksModeIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public NavigatorUserAgentIssueDetails NavigatorUserAgentIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public GenericIssueDetails GenericIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DeprecationIssueDetails DeprecationIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ClientHintIssueDetails ClientHintIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FederatedAuthRequestIssueDetails FederatedAuthRequestIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public BounceTrackingIssueDetails BounceTrackingIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CookieDeprecationMetadataIssueDetails CookieDeprecationMetadataIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public StylesheetLoadingIssueDetails StylesheetLoadingIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PropertyRuleIssueDetails PropertyRuleIssueDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FederatedAuthUserInfoRequestIssueDetails FederatedAuthUserInfoRequestIssueDetails { get; set; }
	}
}
