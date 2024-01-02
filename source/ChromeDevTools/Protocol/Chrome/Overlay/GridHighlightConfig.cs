using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Configuration data for the highlighting of Grid elements.

	/// </summary>
	[SupportedBy("Chrome")]
	public class GridHighlightConfig
	{
		/// <summary>
		/// Gets or setsWhether the extension lines from grid cells to the rulers should be shown (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowGridExtensionLines { get; set; }
		/// <summary>
		/// Gets or setsShow Positive line number labels (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowPositiveLineNumbers { get; set; }
		/// <summary>
		/// Gets or setsShow Negative line number labels (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowNegativeLineNumbers { get; set; }
		/// <summary>
		/// Gets or setsShow area name labels (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowAreaNames { get; set; }
		/// <summary>
		/// Gets or setsShow line name labels (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowLineNames { get; set; }
		/// <summary>
		/// Gets or setsShow track size labels (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowTrackSizes { get; set; }
		/// <summary>
		/// Gets or setsThe grid container border highlight color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA GridBorderColor { get; set; }
		/// <summary>
		/// Gets or setsThe cell border color (default: transparent). Deprecated, please use rowLineColor and columnLineColor instead.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA CellBorderColor { get; set; }
		/// <summary>
		/// Gets or setsThe row line color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA RowLineColor { get; set; }
		/// <summary>
		/// Gets or setsThe column line color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ColumnLineColor { get; set; }
		/// <summary>
		/// Gets or setsWhether the grid border is dashed (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? GridBorderDash { get; set; }
		/// <summary>
		/// Gets or setsWhether the cell border is dashed (default: false). Deprecated, please us rowLineDash and columnLineDash instead.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CellBorderDash { get; set; }
		/// <summary>
		/// Gets or setsWhether row lines are dashed (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? RowLineDash { get; set; }
		/// <summary>
		/// Gets or setsWhether column lines are dashed (default: false).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ColumnLineDash { get; set; }
		/// <summary>
		/// Gets or setsThe row gap highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA RowGapColor { get; set; }
		/// <summary>
		/// Gets or setsThe row gap hatching fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA RowHatchColor { get; set; }
		/// <summary>
		/// Gets or setsThe column gap highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ColumnGapColor { get; set; }
		/// <summary>
		/// Gets or setsThe column gap hatching fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA ColumnHatchColor { get; set; }
		/// <summary>
		/// Gets or setsThe named grid areas border color (Default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA AreaBorderColor { get; set; }
		/// <summary>
		/// Gets or setsThe grid container background color (Default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA GridBackgroundColor { get; set; }
	}
}
