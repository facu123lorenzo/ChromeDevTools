using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Sets given cookies.

	/// </summary>
	[Command(ProtocolName.Network.SetCookies)]
	[SupportedBy("Chrome")]
	public class SetCookiesCommand: ICommand<SetCookiesCommandResponse>
	{
		/// <summary>
		/// Gets or setsCookies to be set.

		/// </summary>
		public CookieParam[] Cookies { get; set; }
	}
}
