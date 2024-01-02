using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	///Send a list of sources for all preloading attempts in a document.

	/// </summary>
	[Event(ProtocolName.Preload.PreloadingAttemptSourcesUpdated)]
	[SupportedBy("Chrome")]
	public class PreloadingAttemptSourcesUpdatedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public PreloadingAttemptSource[] PreloadingAttemptSources { get; set; }
	}
}
