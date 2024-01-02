using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	/// <summary>
	///Resets the cooldown time, if any, to allow the next FedCM call to show
	/// a dialog even if one was recently dismissed by the user.

	/// </summary>
	[Command(ProtocolName.FedCm.ResetCooldown)]
	[SupportedBy("Chrome")]
	public class ResetCooldownCommand: ICommand<ResetCooldownCommandResponse>
	{
	}
}
