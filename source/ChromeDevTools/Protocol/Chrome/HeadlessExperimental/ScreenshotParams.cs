using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeadlessExperimental
{
	/// <summary>
	///Encoding options for a screenshot.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ScreenshotParams
	{
		/// <summary>
		/// Gets or setsImage compression format (defaults to png).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Format { get; set; }
		/// <summary>
		/// Gets or setsCompression quality from range [0..100] (jpeg and webp only).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? Quality { get; set; }
		/// <summary>
		/// Gets or setsOptimize image encoding for speed, not for resulting size (defaults to false)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? OptimizeForSpeed { get; set; }
	}
}
