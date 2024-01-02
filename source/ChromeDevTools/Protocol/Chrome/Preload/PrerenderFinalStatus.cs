using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;


namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload{
	/// <summary>
	///List of FinalStatus reasons for Prerender2.

	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PrerenderFinalStatus
	{
			Activated,
			Destroyed,
			LowEndDevice,
			InvalidSchemeRedirect,
			InvalidSchemeNavigation,
			NavigationRequestBlockedByCsp,
			MainFrameNavigation,
			MojoBinderPolicy,
			RendererProcessCrashed,
			RendererProcessKilled,
			Download,
			TriggerDestroyed,
			NavigationNotCommitted,
			NavigationBadHttpStatus,
			ClientCertRequested,
			NavigationRequestNetworkError,
			CancelAllHostsForTesting,
			DidFailLoad,
			Stop,
			SslCertificateError,
			LoginAuthRequested,
			UaChangeRequiresReload,
			BlockedByClient,
			AudioOutputDeviceRequested,
			MixedContent,
			TriggerBackgrounded,
			MemoryLimitExceeded,
			DataSaverEnabled,
			TriggerUrlHasEffectiveUrl,
			ActivatedBeforeStarted,
			InactivePageRestriction,
			StartFailed,
			TimeoutBackgrounded,
			CrossSiteRedirectInInitialNavigation,
			CrossSiteNavigationInInitialNavigation,
			SameSiteCrossOriginRedirectNotOptInInInitialNavigation,
			SameSiteCrossOriginNavigationNotOptInInInitialNavigation,
			ActivationNavigationParameterMismatch,
			ActivatedInBackground,
			EmbedderHostDisallowed,
			ActivationNavigationDestroyedBeforeSuccess,
			TabClosedByUserGesture,
			TabClosedWithoutUserGesture,
			PrimaryMainFrameRendererProcessCrashed,
			PrimaryMainFrameRendererProcessKilled,
			ActivationFramePolicyNotCompatible,
			PreloadingDisabled,
			BatterySaverEnabled,
			ActivatedDuringMainFrameNavigation,
			PreloadingUnsupportedByWebContents,
			CrossSiteRedirectInMainFrameNavigation,
			CrossSiteNavigationInMainFrameNavigation,
			SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation,
			SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation,
			MemoryPressureOnTrigger,
			MemoryPressureAfterTriggered,
			PrerenderingDisabledByDevTools,
			SpeculationRuleRemoved,
			ActivatedWithAuxiliaryBrowsingContexts,
			MaxNumOfRunningEagerPrerendersExceeded,
			MaxNumOfRunningNonEagerPrerendersExceeded,
			MaxNumOfRunningEmbedderPrerendersExceeded,
			PrerenderingUrlHasEffectiveUrl,
			RedirectedPrerenderingUrlHasEffectiveUrl,
			ActivationUrlHasEffectiveUrl,
	}
}
