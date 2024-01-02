using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Screencast frame metadata.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ScreencastFrameMetadata
	{
		/// <summary>
		/// Gets or setsTop offset in DIP.

		/// </summary>
		public double OffsetTop { get; set; }
		/// <summary>
		/// Gets or setsPage scale factor.

		/// </summary>
		public double PageScaleFactor { get; set; }
		/// <summary>
		/// Gets or setsDevice screen width in DIP.

		/// </summary>
		public double DeviceWidth { get; set; }
		/// <summary>
		/// Gets or setsDevice screen height in DIP.

		/// </summary>
		public double DeviceHeight { get; set; }
		/// <summary>
		/// Gets or setsPosition of horizontal scroll in CSS pixels.

		/// </summary>
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// Gets or setsPosition of vertical scroll in CSS pixels.

		/// </summary>
		public double ScrollOffsetY { get; set; }
		/// <summary>
		/// Gets or setsFrame swap timestamp.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Timestamp { get; set; }
	}
}
