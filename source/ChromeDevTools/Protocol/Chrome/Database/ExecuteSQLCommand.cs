using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Database
{
	[Command(ProtocolName.Database.ExecuteSQL)]
	[SupportedBy("Chrome")]
	public class ExecuteSQLCommand: ICommand<ExecuteSQLCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DatabaseId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Query { get; set; }
	}
}
