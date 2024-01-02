using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Target
{
	/// <summary>
	///Detaches session with given id.

	/// </summary>
	[Command(ProtocolName.Target.DetachFromTarget)]
	[SupportedBy("Chrome")]
	public class DetachFromTargetCommand: ICommand<DetachFromTargetCommandResponse>
	{
		/// <summary>
		/// Gets or setsSession to detach.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string SessionId { get; set; }
		/// <summary>
		/// Gets or setsDeprecated.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string TargetId { get; set; }
	}
}
