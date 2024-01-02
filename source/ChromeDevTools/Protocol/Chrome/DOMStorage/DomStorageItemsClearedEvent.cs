using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemsCleared)]
	[SupportedBy("Chrome")]
	public class DomStorageItemsClearedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
