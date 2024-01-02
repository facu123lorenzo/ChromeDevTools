using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Command(ProtocolName.Worker.SendMessageToWorker)]
	[SupportedBy("iOS")]
	public class SendMessageToWorkerCommand: ICommand<SendMessageToWorkerCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long WorkerId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public object Message { get; set; }
	}
}
