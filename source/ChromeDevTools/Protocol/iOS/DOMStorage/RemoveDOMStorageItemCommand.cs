using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Command(ProtocolName.DOMStorage.RemoveDOMStorageItem)]
	[SupportedBy("iOS")]
	public class RemoveDOMStorageItemCommand: ICommand<RemoveDOMStorageItemCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Key { get; set; }
	}
}
