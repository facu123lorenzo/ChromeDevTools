using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Event(ProtocolName.FedCm.DialogShown)]
	[SupportedBy("Chrome")]
	public class DialogShownEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public DialogType DialogType { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Account[] Accounts { get; set; }
		/// <summary>
		/// Gets or setsThese exist primarily so that the caller can verify the
		/// RP context was used appropriately.

		/// </summary>
		public string Title { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Subtitle { get; set; }
	}
}
