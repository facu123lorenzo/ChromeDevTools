using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Timeline
{
	/// <summary>
	///Timeline record contains information about the recorded activity.

	/// </summary>
	[SupportedBy("iOS")]
	public class TimelineEvent
	{
		/// <summary>
		/// Gets or setsEvent type.

		/// </summary>
		public EventType Type { get; set; }
		/// <summary>
		/// Gets or setsEvent data.

		/// </summary>
		public object Data { get; set; }
		/// <summary>
		/// Gets or setsNested records.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public TimelineEvent[] Children { get; set; }
	}
}
