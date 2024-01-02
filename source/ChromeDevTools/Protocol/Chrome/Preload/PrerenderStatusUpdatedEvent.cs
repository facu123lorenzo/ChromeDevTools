using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	///Fired when a prerender attempt is updated.

	/// </summary>
	[Event(ProtocolName.Preload.PrerenderStatusUpdated)]
	[SupportedBy("Chrome")]
	public class PrerenderStatusUpdatedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public PreloadingAttemptKey Key { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public PreloadingStatus Status { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PrerenderFinalStatus PrerenderStatus { get; set; }
		/// <summary>
		/// Gets or setsThis is used to give users more information about the name of Mojo interface
		/// that is incompatible with prerender and has caused the cancellation of the attempt.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string DisallowedMojoInterface { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public PrerenderMismatchedHeaders[] MismatchedHeaders { get; set; }
	}
}
