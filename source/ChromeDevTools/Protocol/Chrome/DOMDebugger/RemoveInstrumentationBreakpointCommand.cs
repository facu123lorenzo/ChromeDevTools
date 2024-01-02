using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	///Removes breakpoint on particular native event.

	/// </summary>
	[Obsolete]
	[Command(ProtocolName.DOMDebugger.RemoveInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class RemoveInstrumentationBreakpointCommand: ICommand<RemoveInstrumentationBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or setsInstrumentation name to stop on.

		/// </summary>
		public string EventName { get; set; }
	}
}
