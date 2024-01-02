using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Accessibility
{
	/// <summary>
	///A single computed AX property.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AXValue
	{
		/// <summary>
		/// Gets or setsThe type of this value.

		/// </summary>
		public AXValueType Type { get; set; }
		/// <summary>
		/// Gets or setsThe computed value of this property.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Value { get; set; }
		/// <summary>
		/// Gets or setsOne or more related nodes, if applicable.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXRelatedNode[] RelatedNodes { get; set; }
		/// <summary>
		/// Gets or setsThe sources which contributed to the computation of this property.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public AXValueSource[] Sources { get; set; }
	}
}
