using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.DeliverPushMessage)]
	[SupportedBy("Chrome")]
	public class DeliverPushMessageCommand: ICommand<DeliverPushMessageCommandResponse>
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
		public string Data { get; set; }
	}
}
