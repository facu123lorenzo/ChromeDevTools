using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DispatchSyncEvent)]
	[SupportedBy("Chrome")]
	public class DispatchSyncEventCommand: ICommand<DispatchSyncEventCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Tag { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool LastChance { get; set; }
	}
}
