using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	[Command(ProtocolName.FedCm.SelectAccount)]
	[SupportedBy("Chrome")]
	public class SelectAccountCommand: ICommand<SelectAccountCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DialogId { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public long AccountIndex { get; set; }
	}
}
