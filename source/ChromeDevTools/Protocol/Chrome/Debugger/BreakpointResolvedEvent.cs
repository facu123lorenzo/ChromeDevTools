using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Fired when breakpoint is resolved to an actual script and location.

	/// </summary>
	[Event(ProtocolName.Debugger.BreakpointResolved)]
	[SupportedBy("Chrome")]
	public class BreakpointResolvedEvent
	{
		/// <summary>
		/// Gets or setsBreakpoint unique identifier.

		/// </summary>
		public string BreakpointId { get; set; }
		/// <summary>
		/// Gets or setsActual breakpoint location.

		/// </summary>
		public Location Location { get; set; }
	}
}
