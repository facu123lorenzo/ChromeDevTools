using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Gets the entries in an given origin's shared storage.

	/// </summary>
	[Command(ProtocolName.Storage.GetSharedStorageEntries)]
	[SupportedBy("Chrome")]
	public class GetSharedStorageEntriesCommand: ICommand<GetSharedStorageEntriesCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
