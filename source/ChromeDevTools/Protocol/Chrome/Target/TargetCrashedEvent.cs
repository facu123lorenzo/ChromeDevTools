using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	///Issued when a target has crashed.

	/// </summary>
	[Event(ProtocolName.Target.TargetCrashed)]
	[SupportedBy("Chrome")]
	public class TargetCrashedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string TargetId { get; set; }
		/// <summary>
		/// Gets or setsTermination status type.

		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Gets or setsTermination error code.

		/// </summary>
		public long ErrorCode { get; set; }
	}
}
