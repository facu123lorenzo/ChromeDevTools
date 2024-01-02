using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Overrides the Device Orientation.

	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome")]
	public class SetDeviceOrientationOverrideCommand: ICommand<SetDeviceOrientationOverrideCommandResponse>
	{
		/// <summary>
		/// Gets or setsMock alpha

		/// </summary>
		public double Alpha { get; set; }
		/// <summary>
		/// Gets or setsMock beta

		/// </summary>
		public double Beta { get; set; }
		/// <summary>
		/// Gets or setsMock gamma

		/// </summary>
		public double Gamma { get; set; }
	}
}
