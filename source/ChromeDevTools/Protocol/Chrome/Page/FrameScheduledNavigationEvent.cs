using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Fired when frame schedules a potential navigation.

	/// </summary>
	[Event(ProtocolName.Page.FrameScheduledNavigation)]
	[SupportedBy("Chrome")]
	public class FrameScheduledNavigationEvent
	{
		/// <summary>
		/// Gets or setsId of the frame that has scheduled a navigation.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsDelay (in seconds) until the navigation is scheduled to begin. The navigation is not
		/// guaranteed to start.

		/// </summary>
		public double Delay { get; set; }
		/// <summary>
		/// Gets or setsThe reason for the navigation.

		/// </summary>
		public ClientNavigationReason Reason { get; set; }
		/// <summary>
		/// Gets or setsThe destination URL for the scheduled navigation.

		/// </summary>
		public string Url { get; set; }
	}
}
