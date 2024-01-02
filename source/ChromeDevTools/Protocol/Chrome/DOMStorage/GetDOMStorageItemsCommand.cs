using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMStorage
{
	[Command(ProtocolName.DOMStorage.GetDOMStorageItems)]
	[SupportedBy("Chrome")]
	public class GetDOMStorageItemsCommand: ICommand<GetDOMStorageItemsCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public StorageId StorageId { get; set; }
	}
}
