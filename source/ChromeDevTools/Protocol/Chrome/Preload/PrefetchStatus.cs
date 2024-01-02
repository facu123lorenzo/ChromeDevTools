using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload{
	/// <summary>
	///TODO(https://crbug.com/1384419): revisit the list of PrefetchStatus and
	/// filter out the ones that aren't necessary to the developers.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrefetchStatus
	{
			PrefetchAllowed,
			PrefetchFailedIneligibleRedirect,
			PrefetchFailedInvalidRedirect,
			PrefetchFailedMIMENotSupported,
			PrefetchFailedNetError,
			PrefetchFailedNon2XX,
			PrefetchFailedPerPageLimitExceeded,
			PrefetchEvictedAfterCandidateRemoved,
			PrefetchEvictedForNewerPrefetch,
			PrefetchHeldback,
			PrefetchIneligibleRetryAfter,
			PrefetchIsPrivacyDecoy,
			PrefetchIsStale,
			PrefetchNotEligibleBrowserContextOffTheRecord,
			PrefetchNotEligibleDataSaverEnabled,
			PrefetchNotEligibleExistingProxy,
			PrefetchNotEligibleHostIsNonUnique,
			PrefetchNotEligibleNonDefaultStoragePartition,
			PrefetchNotEligibleSameSiteCrossOriginPrefetchRequiredProxy,
			PrefetchNotEligibleSchemeIsNotHttps,
			PrefetchNotEligibleUserHasCookies,
			PrefetchNotEligibleUserHasServiceWorker,
			PrefetchNotEligibleBatterySaverEnabled,
			PrefetchNotEligiblePreloadingDisabled,
			PrefetchNotFinishedInTime,
			PrefetchNotStarted,
			PrefetchNotUsedCookiesChanged,
			PrefetchProxyNotAvailable,
			PrefetchResponseUsed,
			PrefetchSuccessfulButNotUsed,
			PrefetchNotUsedProbeFailed,
	}
}
