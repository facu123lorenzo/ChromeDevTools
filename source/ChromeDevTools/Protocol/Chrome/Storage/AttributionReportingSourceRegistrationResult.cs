using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage{
	/// <summary>
	///

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttributionReportingSourceRegistrationResult
	{
			Success,
			InternalError,
			InsufficientSourceCapacity,
			InsufficientUniqueDestinationCapacity,
			ExcessiveReportingOrigins,
			ProhibitedByBrowserPolicy,
			SuccessNoised,
			DestinationReportingLimitReached,
			DestinationGlobalLimitReached,
			DestinationBothLimitsReached,
			ReportingOriginsPerSiteLimitReached,
			ExceedsMaxChannelCapacity,
	}
}
