using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Set tracking for a storage key's buckets.

	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetStorageBucketTracking)]
	[SupportedBy("Chrome")]
	public class SetStorageBucketTrackingCommandResponse
	{
	}
}
