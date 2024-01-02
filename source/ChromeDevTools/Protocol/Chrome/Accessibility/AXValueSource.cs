using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	///A single source for a computed AX property.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AXValueSource
	{
		/// <summary>
		/// Gets or setsWhat type of source this is.

		/// </summary>
		public AXValueSourceType Type { get; set; }
		/// <summary>
		/// Gets or setsThe value of this property source.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue Value { get; set; }
		/// <summary>
		/// Gets or setsThe name of the relevant attribute, if any.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Attribute { get; set; }
		/// <summary>
		/// Gets or setsThe value of the relevant attribute, if any.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue AttributeValue { get; set; }
		/// <summary>
		/// Gets or setsWhether this source is superseded by a higher priority source.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Superseded { get; set; }
		/// <summary>
		/// Gets or setsThe native markup source for this value, e.g. a `<label>` element.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValueNativeSourceType NativeSource { get; set; }
		/// <summary>
		/// Gets or setsThe value, such as a node or node list, of the native source.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValue NativeSourceValue { get; set; }
		/// <summary>
		/// Gets or setsWhether the value for this property is invalid.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Invalid { get; set; }
		/// <summary>
		/// Gets or setsReason for the value being invalid, if it is.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InvalidReason { get; set; }
	}
}
