using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.IndexedDB
{
	/// <summary>
	///Requests database names for given security origin.

	/// </summary>
	[CommandResponse(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("iOS")]
	public class RequestDatabaseNamesCommandResponse
	{
		/// <summary>
		/// Gets or setsDatabase names for origin.

		/// </summary>
		public string[] DatabaseNames { get; set; }
	}
}
