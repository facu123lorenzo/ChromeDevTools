using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingSourceRegistration
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double Time { get; set; }
		/// <summary>
		/// Gets or setsduration in seconds

		/// </summary>
		public long Expiry { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingTriggerSpec[] TriggerSpecs { get; set; }
		/// <summary>
		/// Gets or setsduration in seconds

		/// </summary>
		public long AggregatableReportWindow { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingSourceType Type { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string SourceOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ReportingOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string[] DestinationSites { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string EventId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Priority { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterDataEntry[] FilterData { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingAggregationKeysEntry[] AggregationKeys { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DebugKey { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingTriggerDataMatching TriggerDataMatching { get; set; }
	}
}
