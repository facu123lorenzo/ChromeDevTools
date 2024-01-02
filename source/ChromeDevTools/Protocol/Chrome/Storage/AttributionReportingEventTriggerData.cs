using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingEventTriggerData
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Priority { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DedupKey { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterPair Filters { get; set; }
	}
}
