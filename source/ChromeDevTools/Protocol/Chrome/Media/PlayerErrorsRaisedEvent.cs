using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Media
{
	/// <summary>
	///Send a list of any errors that need to be delivered.

	/// </summary>
	[Event(ProtocolName.Media.PlayerErrorsRaised)]
	[SupportedBy("Chrome")]
	public class PlayerErrorsRaisedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string PlayerId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public PlayerError[] Errors { get; set; }
	}
}
