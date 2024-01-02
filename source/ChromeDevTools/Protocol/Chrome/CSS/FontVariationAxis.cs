using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Information about font variation axes for variable fonts

	/// </summary>
	[SupportedBy("Chrome")]
	public class FontVariationAxis
	{
		/// <summary>
		/// Gets or setsThe font-variation-setting tag (a.k.a. "axis tag").

		/// </summary>
		public string Tag { get; set; }
		/// <summary>
		/// Gets or setsHuman-readable variation name in the default language (normally, "en").

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsThe minimum value (inclusive) the font supports for this tag.

		/// </summary>
		public double MinValue { get; set; }
		/// <summary>
		/// Gets or setsThe maximum value (inclusive) the font supports for this tag.

		/// </summary>
		public double MaxValue { get; set; }
		/// <summary>
		/// Gets or setsThe default value.

		/// </summary>
		public double DefaultValue { get; set; }
	}
}
