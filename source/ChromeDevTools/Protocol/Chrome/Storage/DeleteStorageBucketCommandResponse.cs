using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Deletes the Storage Bucket with the given storage key and bucket name.

	/// </summary>
	[CommandResponse(ProtocolName.Storage.DeleteStorageBucket)]
	[SupportedBy("Chrome")]
	public class DeleteStorageBucketCommandResponse
	{
	}
}
