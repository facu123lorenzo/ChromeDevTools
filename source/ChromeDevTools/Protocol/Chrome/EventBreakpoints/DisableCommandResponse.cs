using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.EventBreakpoints
{
	/// <summary>
	///Removes all breakpoints

	/// </summary>
	[CommandResponse(ProtocolName.EventBreakpoints.Disable)]
	[SupportedBy("Chrome")]
	public class DisableCommandResponse
	{
	}
}
