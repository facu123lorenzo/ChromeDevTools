using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Unregisters storage key from receiving notifications for cache storage.

	/// </summary>
	[Command(ProtocolName.Storage.UntrackCacheStorageForStorageKey)]
	[SupportedBy("Chrome")]
	public class UntrackCacheStorageForStorageKeyCommand: ICommand<UntrackCacheStorageForStorageKeyCommandResponse>
	{
		/// <summary>
		/// Gets or setsStorage key.

		/// </summary>
		public string StorageKey { get; set; }
	}
}
