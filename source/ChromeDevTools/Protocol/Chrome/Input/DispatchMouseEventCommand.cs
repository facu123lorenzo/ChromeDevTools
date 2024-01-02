using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	///Dispatches a mouse event to the page.

	/// </summary>
	[Command(ProtocolName.Input.DispatchMouseEvent)]
	[SupportedBy("Chrome")]
	public class DispatchMouseEventCommand: ICommand<DispatchMouseEventCommandResponse>
	{
		/// <summary>
		/// Gets or setsType of the mouse event.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsX coordinate of the event relative to the main frame's viewport in CSS pixels.

		/// </summary>
		public double X { get; set; }
		/// <summary>
		/// Gets or setsY coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
		/// the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.

		/// </summary>
		public double Y { get; set; }
		/// <summary>
		/// Gets or setsBit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
		/// (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Modifiers { get; set; }
		/// <summary>
		/// Gets or setsTime at which the event occurred.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsMouse button (default: "none").

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Button { get; set; }
		/// <summary>
		/// Gets or setsA number indicating which buttons are pressed on the mouse when a mouse event is triggered.
		/// Left=1, Right=2, Middle=4, Back=8, Forward=16, None=0.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Buttons { get; set; }
		/// <summary>
		/// Gets or setsNumber of times the mouse button was clicked (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ClickCount { get; set; }
		/// <summary>
		/// Gets or setsThe normalized pressure, which has a range of [0,1] (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Force { get; set; }
		/// <summary>
		/// Gets or setsThe normalized tangential pressure, which has a range of [-1,1] (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double TangentialPressure { get; set; }
		/// <summary>
		/// Gets or setsThe plane angle between the Y-Z plane and the plane containing both the stylus axis and the Y axis, in degrees of the range [-90,90], a positive tiltX is to the right (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double TiltX { get; set; }
		/// <summary>
		/// Gets or setsThe plane angle between the X-Z plane and the plane containing both the stylus axis and the X axis, in degrees of the range [-90,90], a positive tiltY is towards the user (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double TiltY { get; set; }
		/// <summary>
		/// Gets or setsThe clockwise rotation of a pen stylus around its own major axis, in degrees in the range [0,359] (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Twist { get; set; }
		/// <summary>
		/// Gets or setsX delta in CSS pixels for mouse wheel event (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaX { get; set; }
		/// <summary>
		/// Gets or setsY delta in CSS pixels for mouse wheel event (default: 0).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double DeltaY { get; set; }
		/// <summary>
		/// Gets or setsPointer type (default: "mouse").

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string PointerType { get; set; }
	}
}
