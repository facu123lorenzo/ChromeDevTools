using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOM
{
	/// <summary>
	///Highlights given quad. Coordinates are absolute with respect to the main frame viewport.

	/// </summary>
	[Command(ProtocolName.DOM.HighlightQuad)]
	[SupportedBy("iOS")]
	public class HighlightQuadCommand: ICommand<HighlightQuadCommandResponse>
	{
		/// <summary>
		/// Gets or setsQuad to highlight

		/// </summary>
		public double[] Quad { get; set; }
		/// <summary>
		/// Gets or setsThe highlight fill color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor Color { get; set; }
		/// <summary>
		/// Gets or setsThe highlight outline color (default: transparent).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RGBAColor OutlineColor { get; set; }
		/// <summary>
		/// Gets or setsIndicates whether the provided parameters are in page coordinates or in viewport coordinates (the default).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? UsePageCoordinates { get; set; }
	}
}
