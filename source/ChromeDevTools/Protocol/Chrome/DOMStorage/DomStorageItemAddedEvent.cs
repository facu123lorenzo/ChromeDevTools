using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Event(ProtocolName.DOMStorage.DomStorageItemAdded)]
	[SupportedBy("Chrome")]
	public class DomStorageItemAddedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageId StorageId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Key { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string NewValue { get; set; }
	}
}
