using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	[Event(ProtocolName.Storage.StorageBucketCreatedOrUpdated)]
	[SupportedBy("Chrome")]
	public class StorageBucketCreatedOrUpdatedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageBucketInfo BucketInfo { get; set; }
	}
}
