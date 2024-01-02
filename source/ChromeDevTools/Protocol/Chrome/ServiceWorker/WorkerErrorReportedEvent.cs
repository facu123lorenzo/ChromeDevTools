using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.ServiceWorker
{
	[Event(ProtocolName.ServiceWorker.WorkerErrorReported)]
	[SupportedBy("Chrome")]
	public class WorkerErrorReportedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ServiceWorkerErrorMessage ErrorMessage { get; set; }
	}
}
