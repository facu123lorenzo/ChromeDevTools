using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	/// <summary>
	///See https://github.com/WICG/LargestContentfulPaint and largest_contentful_paint.idl

	/// </summary>
	[SupportedBy("Chrome")]
	public class LargestContentfulPaint
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double RenderTime { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double LoadTime { get; set; }
		/// <summary>
		/// Gets or setsThe number of pixels being painted.

		/// </summary>
		public double Size { get; set; }
		/// <summary>
		/// Gets or setsThe id attribute of the element, if available.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ElementId { get; set; }
		/// <summary>
		/// Gets or setsThe URL of the image (may be trimmed).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
