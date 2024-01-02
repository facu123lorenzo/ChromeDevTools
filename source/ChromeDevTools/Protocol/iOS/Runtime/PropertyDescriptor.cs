using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Runtime
{
	/// <summary>
	///Object property descriptor.

	/// </summary>
	[SupportedBy("iOS")]
	public class PropertyDescriptor
	{
		/// <summary>
		/// Gets or setsProperty name or symbol description.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsThe value associated with the property.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Value { get; set; }
		/// <summary>
		/// Gets or setsTrue if the value associated with the property may be changed (data descriptors only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Writable { get; set; }
		/// <summary>
		/// Gets or setsA function which serves as a getter for the property, or <code>undefined</code> if there is no getter (accessor descriptors only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Get { get; set; }
		/// <summary>
		/// Gets or setsA function which serves as a setter for the property, or <code>undefined</code> if there is no setter (accessor descriptors only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public RemoteObject Set { get; set; }
		/// <summary>
		/// Gets or setsTrue if the type of this property descriptor may be changed and if the property may be deleted from the corresponding object.

		/// </summary>
		public bool Configurable { get; set; }
		/// <summary>
		/// Gets or setsTrue if this property shows up during enumeration of the properties on the corresponding object.

		/// </summary>
		public bool Enumerable { get; set; }
		/// <summary>
		/// Gets or setsTrue if the result was thrown during the evaluation.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? WasThrown { get; set; }
		/// <summary>
		/// Gets or setsTrue if the property is owned for the object.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IsOwn { get; set; }
		/// <summary>
		/// Gets or setsProperty symbol object, if the property is a symbol.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.RemoteObject Symbol { get; set; }
		/// <summary>
		/// Gets or setsTrue if the property value came from a native getter.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? NativeGetter { get; set; }
	}
}
