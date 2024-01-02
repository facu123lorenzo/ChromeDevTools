using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Set dock tile details, platform-specific.

	/// </summary>
	[Command(ProtocolName.Browser.SetDockTile)]
	[SupportedBy("Chrome")]
	public class SetDockTileCommand: ICommand<SetDockTileCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string BadgeLabel { get; set; }
		/// <summary>
		/// Gets or setsPng encoded image. (Encoded as a base64 string when passed over JSON)

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Image { get; set; }
	}
}
