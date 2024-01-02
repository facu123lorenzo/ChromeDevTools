using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[Event(ProtocolName.Storage.AttributionReportingTriggerRegistered)]
	[SupportedBy("Chrome")]
	public class AttributionReportingTriggerRegisteredEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingTriggerRegistration Registration { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingEventLevelResult EventLevel { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AttributionReportingAggregatableResult Aggregatable { get; set; }
	}
}
