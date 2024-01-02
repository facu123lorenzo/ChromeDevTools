using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	///

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttributionReportingAggregatableResult
	{
			Success,
			InternalError,
			NoCapacityForAttributionDestination,
			NoMatchingSources,
			ExcessiveAttributions,
			ExcessiveReportingOrigins,
			NoHistograms,
			InsufficientBudget,
			NoMatchingSourceFilterData,
			NotRegistered,
			ProhibitedByBrowserPolicy,
			Deduplicated,
			ReportWindowPassed,
			ExcessiveReports,
	}
}
