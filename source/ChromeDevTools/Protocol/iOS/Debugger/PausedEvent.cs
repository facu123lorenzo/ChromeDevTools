using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Debugger
{
	/// <summary>
	///Fired when the virtual machine stopped on breakpoint or exception or any other stop criteria.

	/// </summary>
	[Event(ProtocolName.Debugger.Paused)]
	[SupportedBy("iOS")]
	public class PausedEvent
	{
		/// <summary>
		/// Gets or setsCall stack the virtual machine stopped on.

		/// </summary>
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or setsPause reason.

		/// </summary>
		public string Reason { get; set; }
		/// <summary>
		/// Gets or setsObject containing break-specific auxiliary properties.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public object Data { get; set; }
	}
}
