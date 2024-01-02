using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	[SupportedBy("Chrome")]
	public class GetObjectByHeapObjectIdCommandResponse
	{
		/// <summary>
		/// Gets or setsEvaluation result.

		/// </summary>
		public Runtime.RemoteObject Result { get; set; }
	}
}
