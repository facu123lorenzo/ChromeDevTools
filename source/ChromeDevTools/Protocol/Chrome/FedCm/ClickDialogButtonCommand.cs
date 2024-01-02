using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.ClickDialogButton)]
	[SupportedBy("Chrome")]
	public class ClickDialogButtonCommand: ICommand<ClickDialogButtonCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DialogButton { get; set; }
	}
}
