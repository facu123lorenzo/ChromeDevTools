using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Page
{
	/// <summary>
	///Information about the Frame hierarchy along with their cached resources.

	/// </summary>
	[SupportedBy("iOS")]
	public class FrameResourceTree
	{
		/// <summary>
		/// Gets or setsFrame information for this tree item.

		/// </summary>
		public Frame Frame { get; set; }
		/// <summary>
		/// Gets or setsChild frames.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public FrameResourceTree[] ChildFrames { get; set; }
		/// <summary>
		/// Gets or setsInformation about frame resources.

		/// </summary>
		public FrameResource[] Resources { get; set; }
	}
}
