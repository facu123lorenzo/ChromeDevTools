using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation
{
	/// <summary>
	///Overrides a platform sensor of a given type. If |enabled| is true, calls to
	/// Sensor.start() will use a virtual sensor as backend rather than fetching
	/// data from a real hardware sensor. Otherwise, existing virtual
	/// sensor-backend Sensor objects will fire an error event and new calls to
	/// Sensor.start() will attempt to use a real sensor instead.

	/// </summary>
	[Command(ProtocolName.Emulation.SetSensorOverrideEnabled)]
	[SupportedBy("Chrome")]
	public class SetSensorOverrideEnabledCommand: ICommand<SetSensorOverrideEnabledCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SensorMetadata Metadata { get; set; }
	}
}
