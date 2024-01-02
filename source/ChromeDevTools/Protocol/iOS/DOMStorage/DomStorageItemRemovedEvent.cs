using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemRemoved)]
	[SupportedBy("iOS")]
	public class DomStorageItemRemovedEvent
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
