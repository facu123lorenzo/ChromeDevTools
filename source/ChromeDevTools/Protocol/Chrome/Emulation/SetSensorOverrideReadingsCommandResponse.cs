using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	///Updates the sensor readings reported by a sensor type previously overriden
	/// by setSensorOverrideEnabled.

	/// </summary>
	[CommandResponse(ProtocolName.Emulation.SetSensorOverrideReadings)]
	[SupportedBy("Chrome")]
	public class SetSensorOverrideReadingsCommandResponse
	{
	}
}
