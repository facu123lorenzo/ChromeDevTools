using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	/// <summary>
	///Deletes browser cookie with given name, domain and path.

	/// </summary>
	[Obsolete]
	[Command(ProtocolName.Page.DeleteCookie)]
	[SupportedBy("Chrome")]
	public class DeleteCookieCommand: ICommand<DeleteCookieCommandResponse>
	{
		/// <summary>
		/// Gets or setsName of the cookie to remove.

		/// </summary>
		public string CookieName { get; set; }
		/// <summary>
		/// Gets or setsURL to match cooke domain and path.

		/// </summary>
		public string Url { get; set; }
	}
}
