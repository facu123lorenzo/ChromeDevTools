using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("Chrome")]
	public class GetDatabaseTableNamesCommand: ICommand<GetDatabaseTableNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DatabaseId { get; set; }
	}
}
