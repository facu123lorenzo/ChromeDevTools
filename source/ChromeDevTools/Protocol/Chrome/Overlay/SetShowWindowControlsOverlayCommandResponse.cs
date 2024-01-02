using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Show Window Controls Overlay for PWA

	/// </summary>
	[CommandResponse(ProtocolName.Overlay.SetShowWindowControlsOverlay)]
	[SupportedBy("Chrome")]
	public class SetShowWindowControlsOverlayCommandResponse
	{
	}
}
