using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	[Command(ProtocolName.Overlay.SetShowScrollSnapOverlays)]
	[SupportedBy("Chrome")]
	public class SetShowScrollSnapOverlaysCommand: ICommand<SetShowScrollSnapOverlaysCommandResponse>
	{
		/// <summary>
		/// Gets or setsAn array of node identifiers and descriptors for the highlight appearance.

		/// </summary>
		public ScrollSnapHighlightConfig[] ScrollSnapHighlightConfigs { get; set; }
	}
}
