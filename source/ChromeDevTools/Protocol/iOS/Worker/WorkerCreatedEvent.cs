using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Worker
{
	[Event(ProtocolName.Worker.WorkerCreated)]
	[SupportedBy("iOS")]
	public class WorkerCreatedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long WorkerId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool InspectorConnected { get; set; }
	}
}
