using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Event(ProtocolName.Worker.DispatchMessageFromWorker)]
	[SupportedBy("iOS")]
	public class DispatchMessageFromWorkerEvent
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
