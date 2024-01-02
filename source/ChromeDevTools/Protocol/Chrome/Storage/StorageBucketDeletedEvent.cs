using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[Event(ProtocolName.Storage.StorageBucketDeleted)]
	[SupportedBy("Chrome")]
	public class StorageBucketDeletedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string BucketId { get; set; }
	}
}
