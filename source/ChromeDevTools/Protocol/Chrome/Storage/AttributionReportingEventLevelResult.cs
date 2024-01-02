using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	///

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttributionReportingEventLevelResult
	{
			Success,
			SuccessDroppedLowerPriority,
			InternalError,
			NoCapacityForAttributionDestination,
			NoMatchingSources,
			Deduplicated,
			ExcessiveAttributions,
			PriorityTooLow,
			NeverAttributedSource,
			ExcessiveReportingOrigins,
			NoMatchingSourceFilterData,
			ProhibitedByBrowserPolicy,
			NoMatchingConfigurations,
			ExcessiveReports,
			FalselyAttributedSource,
			ReportWindowPassed,
			NotRegistered,
			ReportWindowNotStarted,
			NoMatchingTriggerData,
	}
}
