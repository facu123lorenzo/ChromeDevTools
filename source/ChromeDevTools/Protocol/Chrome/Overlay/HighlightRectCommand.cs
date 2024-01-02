using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.

	/// </summary>
	[Command(ProtocolName.Overlay.HighlightRect)]
	[SupportedBy("Chrome")]
	public class HighlightRectCommand: ICommand<HighlightRectCommandResponse>
	{
		/// <summary>
		/// Gets or setsX coordinate

		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or setsY coordinate

		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or setsRectangle width

		/// </summary>
		public long Width { get; set; }
		/// <summary>
		/// Gets or setsRectangle height

		/// </summary>
		public long Height { get; set; }
		/// <summary>
		/// Gets or setsThe highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA Color { get; set; }
		/// <summary>
		/// Gets or setsThe highlight outline color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DOM.RGBA OutlineColor { get; set; }
	}
}
