using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Overlay
{
	/// <summary>
	///For testing.

	/// </summary>
	[Command(ProtocolName.Overlay.GetHighlightObjectForTest)]
	[SupportedBy("Chrome")]
	public class GetHighlightObjectForTestCommand: ICommand<GetHighlightObjectForTestCommandResponse>
	{
		/// <summary>
		/// Gets or setsId of the node to get highlight object for.

		/// </summary>
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or setsWhether to include distance info.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeDistance { get; set; }
		/// <summary>
		/// Gets or setsWhether to include style info.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? IncludeStyle { get; set; }
		/// <summary>
		/// Gets or setsThe color format to get config with (default: hex).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ColorFormat { get; set; }
		/// <summary>
		/// Gets or setsWhether to show accessibility info (default: true).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? ShowAccessibilityInfo { get; set; }
	}
}
