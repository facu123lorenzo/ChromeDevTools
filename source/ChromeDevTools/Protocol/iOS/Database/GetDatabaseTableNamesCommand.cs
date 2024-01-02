using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Database
{
	[Command(ProtocolName.Database.GetDatabaseTableNames)]
	[SupportedBy("iOS")]
	public class GetDatabaseTableNamesCommand: ICommand<GetDatabaseTableNamesCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DatabaseId { get; set; }
	}
}
