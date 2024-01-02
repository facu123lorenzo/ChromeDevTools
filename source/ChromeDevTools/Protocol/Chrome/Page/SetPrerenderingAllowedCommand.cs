using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Enable/disable prerendering manually.
	/// 
	/// This command is a short-term solution for https://crbug.com/1440085.
	/// See https://docs.google.com/document/d/12HVmFxYj5Jc-eJr5OmWsa2bqTJsbgGLKI6ZIyx0_wpA
	/// for more details.
	/// 
	/// TODO(https://crbug.com/1440085): Remove this once Puppeteer supports tab targets.

	/// </summary>
	[Command(ProtocolName.Page.SetPrerenderingAllowed)]
	[SupportedBy("Chrome")]
	public class SetPrerenderingAllowedCommand: ICommand<SetPrerenderingAllowedCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool IsAllowed { get; set; }
	}
}
