using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.GetObjectByHeapObjectId)]
	[SupportedBy("Chrome")]
	public class GetObjectByHeapObjectIdCommand: ICommand<GetObjectByHeapObjectIdCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or setsSymbolic group name that can be used to release multiple objects.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
