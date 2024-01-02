using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Fired for top level page lifecycle events such as navigation, load, paint, etc.

	/// </summary>
	[Event(ProtocolName.Page.LifecycleEvent)]
	[SupportedBy("Chrome")]
	public class LifecycleEventEvent
	{
		/// <summary>
		/// Gets or setsId of the frame.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsLoader identifier. Empty string if the request is fetched from worker.

		/// </summary>
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double Timestamp { get; set; }
	}
}
