using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	///Issued when attached to target because of auto-attach or `attachToTarget` command.

	/// </summary>
	[Event(ProtocolName.Target.AttachedToTarget)]
	[SupportedBy("Chrome")]
	public class AttachedToTargetEvent
	{
		/// <summary>
		/// Gets or setsIdentifier assigned to the session used to send/receive messages.

		/// </summary>
		public string SessionId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public TargetInfo TargetInfo { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool WaitingForDebugger { get; set; }
	}
}
