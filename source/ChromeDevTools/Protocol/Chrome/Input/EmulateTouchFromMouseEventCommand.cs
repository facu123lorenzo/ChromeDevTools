using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	///Emulates touch event from the mouse event parameters.

	/// </summary>
	[Command(ProtocolName.Input.EmulateTouchFromMouseEvent)]
	[SupportedBy("Chrome")]
	public class EmulateTouchFromMouseEventCommand: ICommand<EmulateTouchFromMouseEventCommandResponse>
	{
		/// <summary>
		/// Gets or setsType of the mouse event.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsX coordinate of the mouse pointer in DIP.

		/// </summary>
		public long X { get; set; }
		/// <summary>
		/// Gets or setsY coordinate of the mouse pointer in DIP.

		/// </summary>
		public long Y { get; set; }
		/// <summary>
		/// Gets or setsMouse button. Only "none", "left", "right" are supported.

		/// </summary>
		public string Button { get; set; }
		/// <summary>
		/// Gets or setsTime at which the event occurred (default: current time).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsX delta in DIP for mouse wheel event (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaX { get; set; }
		/// <summary>
		/// Gets or setsY delta in DIP for mouse wheel event (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaY { get; set; }
		/// <summary>
		/// Gets or setsBit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
		/// (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
		/// <summary>
		/// Gets or setsNumber of times the mouse button was clicked (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ClickCount { get; set; }
	}
}
