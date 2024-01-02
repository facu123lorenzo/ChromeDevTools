using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///https://wicg.github.io/attribution-reporting-api/

	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetAttributionReportingLocalTestingMode)]
	[SupportedBy("Chrome")]
	public class SetAttributionReportingLocalTestingModeCommandResponse
	{
	}
}
