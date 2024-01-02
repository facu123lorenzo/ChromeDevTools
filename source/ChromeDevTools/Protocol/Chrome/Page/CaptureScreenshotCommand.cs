using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Capture page screenshot.

	/// </summary>
	[Command(ProtocolName.Page.CaptureScreenshot)]
	[SupportedBy("Chrome")]
	public class CaptureScreenshotCommand: ICommand<CaptureScreenshotCommandResponse>
	{
		/// <summary>
		/// Gets or setsImage compression format (defaults to png).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
		/// <summary>
		/// Gets or setsCompression quality from range [0..100] (jpeg only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Quality { get; set; }
		/// <summary>
		/// Gets or setsCapture the screenshot of a given region only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Viewport Clip { get; set; }
		/// <summary>
		/// Gets or setsCapture the screenshot from the surface, rather than the view. Defaults to true.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? FromSurface { get; set; }
		/// <summary>
		/// Gets or setsCapture the screenshot beyond the viewport. Defaults to false.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? CaptureBeyondViewport { get; set; }
		/// <summary>
		/// Gets or setsOptimize image encoding for speed, not for resulting size (defaults to false)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OptimizeForSpeed { get; set; }
	}
}
