using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Object private field descriptor.

	/// </summary>
	[SupportedBy("Chrome")]
	public class PrivatePropertyDescriptor
	{
		/// <summary>
		/// Gets or setsPrivate property name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsThe value associated with the private property.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Value { get; set; }
		/// <summary>
		/// Gets or setsA function which serves as a getter for the private property,
		/// or `undefined` if there is no getter (accessor descriptors only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Get { get; set; }
		/// <summary>
		/// Gets or setsA function which serves as a setter for the private property,
		/// or `undefined` if there is no setter (accessor descriptors only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Set { get; set; }
	}
}
