using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS rule representation.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSRule
	{
		/// <summary>
		/// Gets or setsThe css style sheet identifier (absent for user agent stylesheet and user-specified
		/// stylesheet rules) this rule came from.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or setsRule selector data.

		/// </summary>
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Gets or setsArray of selectors from ancestor style rules, sorted by distance from the current rule.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string[] NestingSelectors { get; set; }
		/// <summary>
		/// Gets or setsParent stylesheet's origin.

		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or setsAssociated style declaration.

		/// </summary>
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Gets or setsMedia list array (for rules involving media queries). The array enumerates media queries
		/// starting with the innermost one, going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSMedia[] Media { get; set; }
		/// <summary>
		/// Gets or setsContainer query list array (for rules involving container queries).
		/// The array enumerates container queries starting with the innermost one, going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSContainerQuery[] ContainerQueries { get; set; }
		/// <summary>
		/// Gets or sets@supports CSS at-rule array.
		/// The array enumerates @supports at-rules starting with the innermost one, going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSSupports[] Supports { get; set; }
		/// <summary>
		/// Gets or setsCascade layer array. Contains the layer hierarchy that this rule belongs to starting
		/// with the innermost layer and going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSLayer[] Layers { get; set; }
		/// <summary>
		/// Gets or sets@scope CSS at-rule array.
		/// The array enumerates @scope at-rules starting with the innermost one, going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSScope[] Scopes { get; set; }
		/// <summary>
		/// Gets or setsThe array keeps the types of ancestor CSSRules from the innermost going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSRuleType[] RuleTypes { get; set; }
	}
}
