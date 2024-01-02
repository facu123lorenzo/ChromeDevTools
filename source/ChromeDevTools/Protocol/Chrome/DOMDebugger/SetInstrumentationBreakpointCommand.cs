using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DOMDebugger
{
	/// <summary>
	///Sets breakpoint on particular native event.

	/// </summary>
	[Obsolete]
	[Command(ProtocolName.DOMDebugger.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome")]
	public class SetInstrumentationBreakpointCommand: ICommand<SetInstrumentationBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or setsInstrumentation name to stop on.

		/// </summary>
		public string EventName { get; set; }
	}
}
