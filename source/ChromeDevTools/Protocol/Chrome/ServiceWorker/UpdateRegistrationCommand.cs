using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.UpdateRegistration)]
	[SupportedBy("Chrome")]
	public class UpdateRegistrationCommand: ICommand<UpdateRegistrationCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ScopeURL { get; set; }
	}
}
