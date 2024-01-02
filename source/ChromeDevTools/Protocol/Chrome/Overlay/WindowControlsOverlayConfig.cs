using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///Configuration for Window Controls Overlay

	/// </summary>
	[SupportedBy("Chrome")]
	public class WindowControlsOverlayConfig
	{
		/// <summary>
		/// Gets or setsWhether the title bar CSS should be shown when emulating the Window Controls Overlay.

		/// </summary>
		public bool ShowCSS { get; set; }
		/// <summary>
		/// Gets or setsSeleted platforms to show the overlay.

		/// </summary>
		public string SelectedPlatform { get; set; }
		/// <summary>
		/// Gets or setsThe theme color defined in app manifest.

		/// </summary>
		public string ThemeColor { get; set; }
	}
}
