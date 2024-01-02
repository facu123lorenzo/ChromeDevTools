using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Debugger
{
	/// <summary>
	///Returns possible locations for breakpoint. scriptId in start and end range locations should be
	/// the same.

	/// </summary>
	[Command(ProtocolName.Debugger.GetPossibleBreakpoints)]
	[SupportedBy("Chrome")]
	public class GetPossibleBreakpointsCommand: ICommand<GetPossibleBreakpointsCommandResponse>
	{
		/// <summary>
		/// Gets or setsStart of range to search possible breakpoint locations in.

		/// </summary>
		public Location Start { get; set; }
		/// <summary>
		/// Gets or setsEnd of range to search possible breakpoint locations in (excluding). When not specified, end
		/// of scripts is used as end of range.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Location End { get; set; }
		/// <summary>
		/// Gets or setsOnly consider locations which are in the same (non-nested) function as start.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? RestrictToFunction { get; set; }
	}
}
