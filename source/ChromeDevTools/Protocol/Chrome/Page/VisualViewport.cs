using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Visual viewport position, dimensions, and scale.

	/// </summary>
	[SupportedBy("Chrome")]
	public class VisualViewport
	{
		/// <summary>
		/// Gets or setsHorizontal offset relative to the layout viewport (CSS pixels).

		/// </summary>
		public double OffsetX { get; set; }
		/// <summary>
		/// Gets or setsVertical offset relative to the layout viewport (CSS pixels).

		/// </summary>
		public double OffsetY { get; set; }
		/// <summary>
		/// Gets or setsHorizontal offset relative to the document (CSS pixels).

		/// </summary>
		public double PageX { get; set; }
		/// <summary>
		/// Gets or setsVertical offset relative to the document (CSS pixels).

		/// </summary>
		public double PageY { get; set; }
		/// <summary>
		/// Gets or setsWidth (CSS pixels), excludes scrollbar if present.

		/// </summary>
		public double ClientWidth { get; set; }
		/// <summary>
		/// Gets or setsHeight (CSS pixels), excludes scrollbar if present.

		/// </summary>
		public double ClientHeight { get; set; }
		/// <summary>
		/// Gets or setsScale relative to the ideal viewport (size at width=device-width).

		/// </summary>
		public double Scale { get; set; }
		/// <summary>
		/// Gets or setsPage zoom factor (CSS to device independent pixels ratio).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Zoom { get; set; }
	}
}
