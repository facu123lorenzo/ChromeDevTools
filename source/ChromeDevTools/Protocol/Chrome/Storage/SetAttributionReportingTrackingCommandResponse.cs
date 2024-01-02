using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Enables/disables issuing of Attribution Reporting events.

	/// </summary>
	[CommandResponse(ProtocolName.Storage.SetAttributionReportingTracking)]
	[SupportedBy("Chrome")]
	public class SetAttributionReportingTrackingCommandResponse
	{
	}
}
