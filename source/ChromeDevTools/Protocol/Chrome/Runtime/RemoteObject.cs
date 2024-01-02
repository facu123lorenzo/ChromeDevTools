using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	///Mirror object referencing original JavaScript object.

	/// </summary>
	[SupportedBy("Chrome")]
	public class RemoteObject
	{
		/// <summary>
		/// Gets or setsObject type.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsObject subtype hint. Specified for `object` type values only.
		/// NOTE: If you change anything here, make sure to also update
		/// `subtype` in `ObjectPreview` and `PropertyPreview` below.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtype { get; set; }
		/// <summary>
		/// Gets or setsObject class (constructor) name. Specified for `object` type values only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ClassName { get; set; }
		/// <summary>
		/// Gets or setsRemote object value in case of primitive values or JSON values (if it was requested).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// Gets or setsPrimitive value which can not be JSON-stringified does not have `value`, but gets this
		/// property.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string UnserializableValue { get; set; }
		/// <summary>
		/// Gets or setsString representation of the object.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Description { get; set; }
		/// <summary>
		/// Gets or setsDeep serialized value.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public DeepSerializedValue DeepSerializedValue { get; set; }
		/// <summary>
		/// Gets or setsUnique object identifier (for non-primitive values).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsPreview containing abbreviated property values. Specified for `object` type values only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public ObjectPreview Preview { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CustomPreview CustomPreview { get; set; }
	}
}
