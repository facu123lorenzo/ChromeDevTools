using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.CSS
{
	/// <summary>
	///Returns the current textual content for a stylesheet.

	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetStyleSheetText)]
	[SupportedBy("Chrome")]
	public class GetStyleSheetTextCommandResponse
	{
		/// <summary>
		/// Gets or setsThe stylesheet text.

		/// </summary>
		public string Text { get; set; }
	}
}
