using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[SupportedBy("Chrome")]
	public class DevicePosture
	{
		/// <summary>
		/// Gets or setsCurrent posture of the device

		/// </summary>
		public string Type { get; set; }
	}
}
