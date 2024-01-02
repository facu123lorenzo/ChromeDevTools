using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Represents deep serialized value.

	/// </summary>
	[SupportedBy("Chrome")]
	public class DeepSerializedValue
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsSet if value reference met more then once during serialization. In such
		/// case, value is provided only to one of the serialized values. Unique
		/// per value in the scope of one CDP call.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? WeakLocalObjectReference { get; set; }
	}
}
