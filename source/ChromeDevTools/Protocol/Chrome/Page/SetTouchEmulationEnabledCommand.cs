using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Toggles mouse event-based touch event emulation.

	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommand: ICommand<SetTouchEmulationEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or setsWhether the touch event emulation should be enabled.

		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or setsTouch/gesture events configuration. Default: current platform.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Configuration { get; set; }
	}
}
