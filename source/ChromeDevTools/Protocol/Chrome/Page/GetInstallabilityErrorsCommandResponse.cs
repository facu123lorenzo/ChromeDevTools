using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Page
{
	[CommandResponse(ProtocolName.Page.GetInstallabilityErrors)]
	[SupportedBy("Chrome")]
	public class GetInstallabilityErrorsCommandResponse
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public InstallabilityError[] InstallabilityErrors { get; set; }
	}
}
