using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network{
	/// <summary>
	///

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrossOriginOpenerPolicyValue
	{
			SameOrigin,
			SameOriginAllowPopups,
			RestrictProperties,
			UnsafeNone,
			SameOriginPlusCoep,
			RestrictPropertiesPlusCoep,
	}
}
