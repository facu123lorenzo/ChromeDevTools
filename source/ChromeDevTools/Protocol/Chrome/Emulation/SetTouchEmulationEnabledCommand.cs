using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	///Enables touch on platforms which do not support them.

	/// </summary>
	[Command(ProtocolName.Emulation.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome")]
	public class SetTouchEmulationEnabledCommand: ICommand<SetTouchEmulationEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or setsWhether the touch event emulation should be enabled.

		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or setsMaximum touch points supported. Defaults to one.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? MaxTouchPoints { get; set; }
	}
}
