using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	///

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AttributionReportingIssueType
	{
			PermissionPolicyDisabled,
			UntrustworthyReportingOrigin,
			InsecureContext,
			InvalidHeader,
			InvalidRegisterTriggerHeader,
			SourceAndTriggerHeaders,
			SourceIgnored,
			TriggerIgnored,
			OsSourceIgnored,
			OsTriggerIgnored,
			InvalidRegisterOsSourceHeader,
			InvalidRegisterOsTriggerHeader,
			WebAndOsHeaders,
			NoWebOrOsSupport,
			NavigationRegistrationWithoutTransientUserActivation,
	}
}
