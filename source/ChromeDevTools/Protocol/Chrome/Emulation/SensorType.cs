using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Emulation{
	/// <summary>
	///Used to specify sensor types to emulate.
	/// See https://w3c.github.io/sensors/#automation for more information.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SensorType
	{
			[EnumMember(Value = "absolute-orientation")]
			Absolute_orientation,
			Accelerometer,
			[EnumMember(Value = "ambient-light")]
			Ambient_light,
			Gravity,
			Gyroscope,
			[EnumMember(Value = "linear-acceleration")]
			Linear_acceleration,
			Magnetometer,
			Proximity,
			[EnumMember(Value = "relative-orientation")]
			Relative_orientation,
	}
}
