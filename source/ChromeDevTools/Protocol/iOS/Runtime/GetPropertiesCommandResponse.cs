using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	///Returns properties of a given object. Object group of the result is inherited from the target object.

	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetProperties)]
	[SupportedBy("iOS")]
	public class GetPropertiesCommandResponse
	{
		/// <summary>
		/// Gets or setsObject properties.

		/// </summary>
		public PropertyDescriptor[] Result { get; set; }
		/// <summary>
		/// Gets or setsInternal object properties.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public InternalPropertyDescriptor[] InternalProperties { get; set; }
	}
}
