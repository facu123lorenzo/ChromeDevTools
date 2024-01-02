using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///CSS property declaration data.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CSSProperty
	{
		/// <summary>
		/// Gets or setsThe property name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsThe property value.

		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Gets or setsWhether the property has "!important" annotation (implies `false` if absent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Important { get; set; }
		/// <summary>
		/// Gets or setsWhether the property is implicit (implies `false` if absent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Implicit { get; set; }
		/// <summary>
		/// Gets or setsThe full property text as specified in the style.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Text { get; set; }
		/// <summary>
		/// Gets or setsWhether the property is understood by the browser (implies `true` if absent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ParsedOk { get; set; }
		/// <summary>
		/// Gets or setsWhether the property is disabled by the user (present for source-based properties only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Disabled { get; set; }
		/// <summary>
		/// Gets or setsThe entire property range in the enclosing style declaration (if available).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceRange Range { get; set; }
		/// <summary>
		/// Gets or setsParsed longhand components of this property if it is a shorthand.
		/// This field will be empty if the given property is not a shorthand.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CSSProperty[] LonghandProperties { get; set; }
	}
}
