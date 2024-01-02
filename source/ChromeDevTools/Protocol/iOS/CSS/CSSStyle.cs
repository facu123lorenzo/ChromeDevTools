using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///CSS style representation.

	/// </summary>
	[SupportedBy("iOS")]
	public class CSSStyle
	{
		/// <summary>
		/// Gets or setsThe CSS style identifier (absent for attribute styles).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSStyleId StyleId { get; set; }
		/// <summary>
		/// Gets or setsCSS properties in the style.

		/// </summary>
		public CSSProperty[] CssProperties { get; set; }
		/// <summary>
		/// Gets or setsComputed values for all shorthands found in the style.

		/// </summary>
		public ShorthandEntry[] ShorthandEntries { get; set; }
		/// <summary>
		/// Gets or setsStyle declaration text (if available).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CssText { get; set; }
		/// <summary>
		/// Gets or setsStyle declaration range in the enclosing stylesheet (if available).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or setsThe effective "width" property value from this style.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Width { get; set; }
		/// <summary>
		/// Gets or setsThe effective "height" property value from this style.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Height { get; set; }
	}
}
