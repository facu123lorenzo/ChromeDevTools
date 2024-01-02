using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.Unregister)]
	[SupportedBy("Chrome")]
	public class UnregisterCommand: ICommand<UnregisterCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ScopeURL { get; set; }
	}
}
