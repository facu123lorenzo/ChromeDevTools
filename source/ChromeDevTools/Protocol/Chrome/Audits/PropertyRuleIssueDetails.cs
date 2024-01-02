using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///This issue warns about errors in property rules that lead to property
	/// registrations being ignored.

	/// </summary>
	[SupportedBy("Chrome")]
	public class PropertyRuleIssueDetails
	{
		/// <summary>
		/// Gets or setsSource code position of the property rule.

		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or setsReason why the property rule was discarded.

		/// </summary>
		public PropertyRuleIssueReason PropertyRuleIssueReason { get; set; }
		/// <summary>
		/// Gets or setsThe value of the property rule property that failed to parse

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PropertyValue { get; set; }
	}
}
