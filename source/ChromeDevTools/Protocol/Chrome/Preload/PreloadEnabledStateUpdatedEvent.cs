using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Preload
{
	/// <summary>
	///Fired when a preload enabled state is updated.

	/// </summary>
	[Event(ProtocolName.Preload.PreloadEnabledStateUpdated)]
	[SupportedBy("Chrome")]
	public class PreloadEnabledStateUpdatedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool DisabledByPreference { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool DisabledByDataSaver { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool DisabledByBatterySaver { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool DisabledByHoldbackPrefetchSpeculationRules { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool DisabledByHoldbackPrerenderSpeculationRules { get; set; }
	}
}
