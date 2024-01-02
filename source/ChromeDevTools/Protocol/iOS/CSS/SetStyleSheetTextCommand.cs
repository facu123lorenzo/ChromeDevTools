using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.CSS
{
	/// <summary>
	///Sets the new stylesheet text, thereby invalidating all existing <code>CSSStyleId</code>'s and <code>CSSRuleId</code>'s contained by this stylesheet.

	/// </summary>
	[Command(ProtocolName.CSS.SetStyleSheetText)]
	[SupportedBy("iOS")]
	public class SetStyleSheetTextCommand: ICommand<SetStyleSheetTextCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string StyleSheetId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Text { get; set; }
	}
}
