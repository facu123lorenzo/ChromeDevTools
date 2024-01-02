using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Properties of a web font: https://www.w3.org/TR/2008/REC-CSS2-20080411/fonts.html#font-descriptions
	/// and additional information such as platformFontFamily and fontVariationAxes.

	/// </summary>
	[SupportedBy("Chrome")]
	public class FontFace
	{
		/// <summary>
		/// Gets or setsThe font-family.

		/// </summary>
		public string FontFamily { get; set; }
		/// <summary>
		/// Gets or setsThe font-style.

		/// </summary>
		public string FontStyle { get; set; }
		/// <summary>
		/// Gets or setsThe font-variant.

		/// </summary>
		public string FontVariant { get; set; }
		/// <summary>
		/// Gets or setsThe font-weight.

		/// </summary>
		public string FontWeight { get; set; }
		/// <summary>
		/// Gets or setsThe font-stretch.

		/// </summary>
		public string FontStretch { get; set; }
		/// <summary>
		/// Gets or setsThe font-display.

		/// </summary>
		public string FontDisplay { get; set; }
		/// <summary>
		/// Gets or setsThe unicode-range.

		/// </summary>
		public string UnicodeRange { get; set; }
		/// <summary>
		/// Gets or setsThe src.

		/// </summary>
		public string Src { get; set; }
		/// <summary>
		/// Gets or setsThe resolved platform font family

		/// </summary>
		public string PlatformFontFamily { get; set; }
		/// <summary>
		/// Gets or setsAvailable variation settings (a.k.a. "axes").

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FontVariationAxis[] FontVariationAxes { get; set; }
	}
}
