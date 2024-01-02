using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	[SupportedBy("Chrome")]
	public class LayoutShiftAttribution
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public DOM.Rect PreviousRect { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public DOM.Rect CurrentRect { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? NodeId { get; set; }
	}
}
