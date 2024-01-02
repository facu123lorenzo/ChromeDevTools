using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Clears storage for origin.

	/// </summary>
	[Command(ProtocolName.Storage.ClearDataForOrigin)]
	[SupportedBy("Chrome")]
	public class ClearDataForOriginCommand: ICommand<ClearDataForOriginCommandResponse>
	{
		/// <summary>
		/// Gets or setsSecurity origin.

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or setsComma separated list of StorageType to clear.

		/// </summary>
		public string StorageTypes { get; set; }
	}
}
