using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Configuration data for the highlighting of page elements.

	/// </summary>
	[SupportedBy("iOS")]
	public class HighlightConfig
	{
		/// <summary>
		/// Gets or setsWhether the node info tooltip should be shown (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowInfo { get; set; }
		/// <summary>
		/// Gets or setsThe content box highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor ContentColor { get; set; }
		/// <summary>
		/// Gets or setsThe padding highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor PaddingColor { get; set; }
		/// <summary>
		/// Gets or setsThe border highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor BorderColor { get; set; }
		/// <summary>
		/// Gets or setsThe margin highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor MarginColor { get; set; }
	}
}
