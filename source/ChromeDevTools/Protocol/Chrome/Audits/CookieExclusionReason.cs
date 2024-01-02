using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	///

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CookieExclusionReason
	{
			ExcludeSameSiteUnspecifiedTreatedAsLax,
			ExcludeSameSiteNoneInsecure,
			ExcludeSameSiteLax,
			ExcludeSameSiteStrict,
			ExcludeInvalidSameParty,
			ExcludeSamePartyCrossPartyContext,
			ExcludeDomainNonASCII,
			ExcludeThirdPartyCookieBlockedInFirstPartySet,
			ExcludeThirdPartyPhaseout,
	}
}
