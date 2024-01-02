using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	[CommandResponse(ProtocolName.Emulation.GetOverriddenSensorInformation)]
	[SupportedBy("Chrome")]
	public class GetOverriddenSensorInformationCommandResponse
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double RequestedSamplingFrequency { get; set; }
	}
}
