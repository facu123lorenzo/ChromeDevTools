using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[Command(ProtocolName.Emulation.GetOverriddenSensorInformation)]
	[SupportedBy("Chrome")]
	public class GetOverriddenSensorInformationCommand: ICommand<GetOverriddenSensorInformationCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Type { get; set; }
	}
}
