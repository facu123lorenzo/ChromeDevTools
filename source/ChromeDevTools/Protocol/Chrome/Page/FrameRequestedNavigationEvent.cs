using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Fired when a renderer-initiated navigation is requested.
	/// Navigation may still be cancelled after the event is issued.

	/// </summary>
	[Event(ProtocolName.Page.FrameRequestedNavigation)]
	[SupportedBy("Chrome")]
	public class FrameRequestedNavigationEvent
	{
		/// <summary>
		/// Gets or setsId of the frame that is being navigated.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsThe reason for the navigation.

		/// </summary>
		public ClientNavigationReason Reason { get; set; }
		/// <summary>
		/// Gets or setsThe destination URL for the requested navigation.

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsThe disposition for the navigation.

		/// </summary>
		public ClientNavigationDisposition Disposition { get; set; }
	}
}
