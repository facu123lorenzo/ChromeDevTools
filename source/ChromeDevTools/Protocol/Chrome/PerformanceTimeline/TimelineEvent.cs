using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.PerformanceTimeline
{
	[SupportedBy("Chrome")]
	public class TimelineEvent
	{
		/// <summary>
		/// Gets or setsIdentifies the frame that this event is related to. Empty for non-frame targets.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsThe event type, as specified in https://w3c.github.io/performance-timeline/#dom-performanceentry-entrytype
		/// This determines which of the optional "details" fiedls is present.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsName may be empty depending on the type.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsTime in seconds since Epoch, monotonically increasing within document lifetime.

		/// </summary>
		public double Time { get; set; }
		/// <summary>
		/// Gets or setsEvent duration, if applicable.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LargestContentfulPaint LcpDetails { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public LayoutShift LayoutShiftDetails { get; set; }
	}
}
