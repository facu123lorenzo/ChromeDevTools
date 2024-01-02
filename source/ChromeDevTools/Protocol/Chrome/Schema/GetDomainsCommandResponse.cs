using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Schema
{
	/// <summary>
	///Returns supported domains.

	/// </summary>
	[CommandResponse(ProtocolName.Schema.GetDomains)]
	[SupportedBy("Chrome")]
	public class GetDomainsCommandResponse
	{
		/// <summary>
		/// Gets or setsList of supported domains.

		/// </summary>
		public Domain[] Domains { get; set; }
	}
}
