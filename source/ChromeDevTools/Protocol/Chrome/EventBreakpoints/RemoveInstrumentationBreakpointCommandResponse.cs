using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.EventBreakpoints
{
	/// <summary>
	///Removes breakpoint on particular native event.

	/// </summary>
	[CommandResponse(ProtocolName.EventBreakpoints.RemoveInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommandResponse
	{
	}
}
