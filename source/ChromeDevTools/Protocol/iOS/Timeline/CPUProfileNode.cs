using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	///CPU Profile node. Holds callsite information, execution statistics and child nodes.

	/// </summary>
	[SupportedBy("iOS")]
	public class CPUProfileNode
	{
		/// <summary>
		/// Gets or setsUnique identifier for this call site.

		/// </summary>
		public long Id { get; set; }
		/// <summary>
		/// Gets or setsAggregate info about all the calls that making up this node.

		/// </summary>
		public CPUProfileNodeAggregateCallInfo CallInfo { get; set; }
		/// <summary>
		/// Gets or setsFunction name.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or setsURL.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsLine number.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LineNumber { get; set; }
		/// <summary>
		/// Gets or setsColumn number.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ColumnNumber { get; set; }
		/// <summary>
		/// Gets or setsChild nodes.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public CPUProfileNode[] Children { get; set; }
	}
}
