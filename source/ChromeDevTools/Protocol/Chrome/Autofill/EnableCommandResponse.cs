using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///Enables autofill domain notifications.

	/// </summary>
	[CommandResponse(ProtocolName.Autofill.Enable)]
	[SupportedBy("Chrome")]
	public class EnableCommandResponse
	{
	}
}
