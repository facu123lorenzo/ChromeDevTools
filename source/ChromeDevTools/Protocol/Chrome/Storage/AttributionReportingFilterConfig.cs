using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingFilterConfig
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterDataEntry[] FilterValues { get; set; }
		/// <summary>
		/// Gets or setsduration in seconds

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? LookbackWindow { get; set; }
	}
}
