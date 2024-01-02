using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///Disables autofill domain notifications.

	/// </summary>
	[CommandResponse(ProtocolName.Autofill.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
