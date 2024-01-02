using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Fired when frame has been attached to its parent.

	/// </summary>
	[Event(ProtocolName.Page.FrameAttached)]
	[SupportedBy("Chrome")]
	public class FrameAttachedEvent
	{
		/// <summary>
		/// Gets or setsId of the frame that has been attached.

		/// </summary>
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsParent frame identifier.

		/// </summary>
		public string ParentFrameId { get; set; }
		/// <summary>
		/// Gets or setsJavaScript stack trace of when frame was attached, only set if frame initiated from script.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Stack { get; set; }
	}
}
