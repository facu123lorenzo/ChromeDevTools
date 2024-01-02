using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits{
	/// <summary>
	///Represents the failure reason when a federated authentication reason fails.
	/// Should be updated alongside RequestIdTokenStatus in
	/// third_party/blink/public/mojom/devtools/inspector_issue.mojom to include
	/// all cases except for success.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FederatedAuthRequestIssueReason
	{
			ShouldEmbargo,
			TooManyRequests,
			WellKnownHttpNotFound,
			WellKnownNoResponse,
			WellKnownInvalidResponse,
			WellKnownListEmpty,
			WellKnownInvalidContentType,
			ConfigNotInWellKnown,
			WellKnownTooBig,
			ConfigHttpNotFound,
			ConfigNoResponse,
			ConfigInvalidResponse,
			ConfigInvalidContentType,
			ClientMetadataHttpNotFound,
			ClientMetadataNoResponse,
			ClientMetadataInvalidResponse,
			ClientMetadataInvalidContentType,
			DisabledInSettings,
			ErrorFetchingSignin,
			InvalidSigninResponse,
			AccountsHttpNotFound,
			AccountsNoResponse,
			AccountsInvalidResponse,
			AccountsListEmpty,
			AccountsInvalidContentType,
			IdTokenHttpNotFound,
			IdTokenNoResponse,
			IdTokenInvalidResponse,
			IdTokenIdpErrorResponse,
			IdTokenCrossSiteIdpErrorResponse,
			IdTokenInvalidRequest,
			IdTokenInvalidContentType,
			ErrorIdToken,
			Canceled,
			RpPageNotVisible,
			SilentMediationFailure,
			ThirdPartyCookiesBlocked,
			NotSignedInWithIdp,
	}
}
