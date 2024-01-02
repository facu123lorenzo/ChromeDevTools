using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Show Window Controls Overlay for PWA

	/// </summary>
	[Command(ProtocolName.Overlay.SetShowWindowControlsOverlay)]
	[SupportedBy("Chrome")]
	public class SetShowWindowControlsOverlayCommand: ICommand<SetShowWindowControlsOverlayCommandResponse>
	{
		/// <summary>
		/// Gets or setsWindow Controls Overlay data, null means hide Window Controls Overlay

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public WindowControlsOverlayConfig WindowControlsOverlayConfig { get; set; }
	}
}
