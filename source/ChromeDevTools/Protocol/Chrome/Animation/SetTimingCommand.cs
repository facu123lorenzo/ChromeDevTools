using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Animation
{
	/// <summary>
	///Sets the timing of an animation node.

	/// </summary>
	[Command(ProtocolName.Animation.SetTiming)]
	[SupportedBy("Chrome")]
	public class SetTimingCommand: ICommand<SetTimingCommandResponse>
	{
		/// <summary>
		/// Gets or setsAnimation id.

		/// </summary>
		public string AnimationId { get; set; }
		/// <summary>
		/// Gets or setsDuration of the animation.

		/// </summary>
		public double Duration { get; set; }
		/// <summary>
		/// Gets or setsDelay of the animation.

		/// </summary>
		public double Delay { get; set; }
	}
}
