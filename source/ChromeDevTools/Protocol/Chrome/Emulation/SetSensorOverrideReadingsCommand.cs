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
	[Command(ProtocolName.Emulation.SetSensorOverrideReadings)]
	[SupportedBy("Chrome")]
	public class SetSensorOverrideReadingsCommand: ICommand<SetSensorOverrideReadingsCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public SensorReading Reading { get; set; }
	}
}
