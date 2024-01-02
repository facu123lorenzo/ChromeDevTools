using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Returns navigation history for the current page.

	/// </summary>
	[CommandResponse(ProtocolName.Page.GetNavigationHistory)]
	[SupportedBy("Chrome")]
	public class GetNavigationHistoryCommandResponse
	{
		/// <summary>
		/// Gets or setsIndex of the current navigation history entry.

		/// </summary>
		public long CurrentIndex { get; set; }
		/// <summary>
		/// Gets or setsArray of navigation history entries.

		/// </summary>
		public NavigationEntry[] Entries { get; set; }
	}
}
