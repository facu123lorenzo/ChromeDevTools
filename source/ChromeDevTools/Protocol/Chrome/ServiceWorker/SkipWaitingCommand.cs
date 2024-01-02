using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.SkipWaiting)]
	[SupportedBy("Chrome")]
	public class SkipWaitingCommand: ICommand<SkipWaitingCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ScopeURL { get; set; }
	}
}
