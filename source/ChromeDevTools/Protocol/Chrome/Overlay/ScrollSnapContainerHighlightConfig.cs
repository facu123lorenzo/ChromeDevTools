using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[SupportedBy("Chrome")]
	public class ScrollSnapContainerHighlightConfig
	{
		/// <summary>
		/// Gets or setsThe style of the snapport border (default: transparent)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle SnapportBorder { get; set; }
		/// <summary>
		/// Gets or setsThe style of the snap area border (default: transparent)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LineStyle SnapAreaBorder { get; set; }
		/// <summary>
		/// Gets or setsThe margin highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ScrollMarginColor { get; set; }
		/// <summary>
		/// Gets or setsThe padding highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ScrollPaddingColor { get; set; }
	}
}
