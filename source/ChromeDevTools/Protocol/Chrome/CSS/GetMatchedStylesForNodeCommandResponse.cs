using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Returns requested styles for a DOM node identified by `nodeId`.

	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetMatchedStylesForNode)]
	[SupportedBy("Chrome")]
	public class GetMatchedStylesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or setsInline style for the specified DOM node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Gets or setsAttribute-defined element style (e.g. resulting from "width=20 height=100%").

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyle AttributesStyle { get; set; }
		/// <summary>
		/// Gets or setsCSS rules matching this node, from all applicable stylesheets.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RuleMatch[] MatchedCSSRules { get; set; }
		/// <summary>
		/// Gets or setsPseudo style matches for this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PseudoElementMatches[] PseudoElements { get; set; }
		/// <summary>
		/// Gets or setsA chain of inherited styles (from the immediate node parent up to the DOM tree root).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InheritedStyleEntry[] Inherited { get; set; }
		/// <summary>
		/// Gets or setsA chain of inherited pseudo element styles (from the immediate node parent up to the DOM tree root).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InheritedPseudoElementMatches[] InheritedPseudoElements { get; set; }
		/// <summary>
		/// Gets or setsA list of CSS keyframed animations matching this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSKeyframesRule[] CssKeyframesRules { get; set; }
		/// <summary>
		/// Gets or setsA list of CSS position fallbacks matching this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSPositionFallbackRule[] CssPositionFallbackRules { get; set; }
		/// <summary>
		/// Gets or setsA list of CSS at-property rules matching this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSPropertyRule[] CssPropertyRules { get; set; }
		/// <summary>
		/// Gets or setsA list of CSS property registrations matching this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSPropertyRegistration[] CssPropertyRegistrations { get; set; }
		/// <summary>
		/// Gets or setsA font-palette-values rule matching this node.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSFontPaletteValuesRule CssFontPaletteValuesRule { get; set; }
		/// <summary>
		/// Gets or setsId of the first parent element that does not have display: contents.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ParentLayoutNodeId { get; set; }
	}
}
