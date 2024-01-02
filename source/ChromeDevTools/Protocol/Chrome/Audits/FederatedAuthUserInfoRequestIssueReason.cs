using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	///Represents the failure reason when a getUserInfo() call fails.
	/// Should be updated alongside FederatedAuthUserInfoRequestResult in
	/// third_party/blink/public/mojom/devtools/inspector_issue.mojom.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FederatedAuthUserInfoRequestIssueReason
	{
			NotSameOrigin,
			NotIframe,
			NotPotentiallyTrustworthy,
			NoApiPermission,
			NotSignedInWithIdp,
			NoAccountSharingPermission,
			InvalidConfigOrWellKnown,
			InvalidAccountsResponse,
			NoReturningUserFromFetchedAccounts,
	}
}
