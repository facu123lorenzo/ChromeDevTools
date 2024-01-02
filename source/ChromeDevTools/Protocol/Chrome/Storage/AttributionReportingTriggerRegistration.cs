using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[SupportedBy("Chrome")]
	public class AttributionReportingTriggerRegistration
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingFilterPair Filters { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DebugKey { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingAggregatableDedupKey[] AggregatableDedupKeys { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingEventTriggerData[] EventTriggerData { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingAggregatableTriggerData[] AggregatableTriggerData { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingAggregatableValueEntry[] AggregatableValues { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool DebugReporting { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string AggregationCoordinatorOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingSourceRegistrationTimeConfig SourceRegistrationTimeConfig { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TriggerContextId { get; set; }
	}
}
