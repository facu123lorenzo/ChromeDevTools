using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Layout viewport position and dimensions.

	/// </summary>
	[SupportedBy("Chrome")]
	public class LayoutViewport
	{
		/// <summary>
		/// Gets or setsHorizontal offset relative to the document (CSS pixels).

		/// </summary>
		public long PageX { get; set; }
		/// <summary>
		/// Gets or setsVertical offset relative to the document (CSS pixels).

		/// </summary>
		public long PageY { get; set; }
		/// <summary>
		/// Gets or setsWidth (CSS pixels), excludes scrollbar if present.

		/// </summary>
		public long ClientWidth { get; set; }
		/// <summary>
		/// Gets or setsHeight (CSS pixels), excludes scrollbar if present.

		/// </summary>
		public long ClientHeight { get; set; }
	}
}
