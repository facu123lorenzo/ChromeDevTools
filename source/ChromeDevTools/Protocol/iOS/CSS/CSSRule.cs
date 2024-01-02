using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///CSS rule representation.

	/// </summary>
	[SupportedBy("iOS")]
	public class CSSRule
	{
		/// <summary>
		/// Gets or setsThe CSS rule identifier (absent for user agent stylesheet and user-specified stylesheet rules).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSRuleId RuleId { get; set; }
		/// <summary>
		/// Gets or setsRule selector data.

		/// </summary>
		public SelectorList SelectorList { get; set; }
		/// <summary>
		/// Gets or setsParent stylesheet resource URL (for regular rules).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or setsLine ordinal of the rule selector start character in the resource.

		/// </summary>
		public long SourceLine { get; set; }
		/// <summary>
		/// Gets or setsParent stylesheet's origin.

		/// </summary>
		public StyleSheetOrigin Origin { get; set; }
		/// <summary>
		/// Gets or setsAssociated style declaration.

		/// </summary>
		public CSSStyle Style { get; set; }
		/// <summary>
		/// Gets or setsMedia list array (for rules involving media queries). The array enumerates media queries starting with the innermost one, going outwards.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSMedia[] Media { get; set; }
	}
}
