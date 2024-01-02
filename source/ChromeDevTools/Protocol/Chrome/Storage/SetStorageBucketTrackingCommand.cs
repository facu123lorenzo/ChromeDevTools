using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Set tracking for a storage key's buckets.

	/// </summary>
	[Command(ProtocolName.Storage.SetStorageBucketTracking)]
	[SupportedBy("Chrome")]
	public class SetStorageBucketTrackingCommand: ICommand<SetStorageBucketTrackingCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string StorageKey { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Enable { get; set; }
	}
}
