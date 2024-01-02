using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	///Removes JavaScript breakpoint.

	/// </summary>
	[Command(ProtocolName.Debugger.RemoveBreakpoint)]
	[SupportedBy("iOS")]
	public class RemoveBreakpointCommand: ICommand<RemoveBreakpointCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string BreakpointId { get; set; }
	}
}
