using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	///Corresponds to SpeculationRuleSet

	/// </summary>
	[SupportedBy("Chrome")]
	public class RuleSet
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or setsIdentifies a document which the rule set is associated with.

		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or setsSource text of JSON representing the rule set. If it comes from
		/// `<script>` tag, it is the textContent of the node. Note that it is
		/// a JSON for valid case.
		/// 
		/// See also:
		/// - https://wicg.github.io/nav-speculation/speculation-rules.html
		/// - https://github.com/WICG/nav-speculation/blob/main/triggers.md

		/// </summary>
		public string SourceText { get; set; }
		/// <summary>
		/// Gets or setsA speculation rule set is either added through an inline
		/// `<script>` tag or through an external resource via the
		/// 'Speculation-Rules' HTTP header. For the first case, we include
		/// the BackendNodeId of the relevant `<script>` tag. For the second
		/// case, we include the external URL where the rule set was loaded
		/// from, and also RequestId if Network domain is enabled.
		/// 
		/// See also:
		/// - https://wicg.github.io/nav-speculation/speculation-rules.html#speculation-rules-script
		/// - https://wicg.github.io/nav-speculation/speculation-rules.html#speculation-rules-header

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsError information
		/// `errorMessage` is null iff `errorType` is null.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RuleSetErrorType ErrorType { get; set; }
		/// <summary>
		/// Gets or setsTODO(https://crbug.com/1425354): Replace this property with structured error.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ErrorMessage { get; set; }
	}
}
