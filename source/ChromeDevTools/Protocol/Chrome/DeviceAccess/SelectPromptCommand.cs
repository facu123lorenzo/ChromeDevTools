using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.DeviceAccess
{
	/// <summary>
	///Select a device in response to a DeviceAccess.deviceRequestPrompted event.

	/// </summary>
	[Command(ProtocolName.DeviceAccess.SelectPrompt)]
	[SupportedBy("Chrome")]
	public class SelectPromptCommand: ICommand<SelectPromptCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DeviceId { get; set; }
	}
}
