using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///Set addresses so that developers can verify their forms implementation.

	/// </summary>
	[Command(ProtocolName.Autofill.SetAddresses)]
	[SupportedBy("Chrome")]
	public class SetAddressesCommand: ICommand<SetAddressesCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Address[] Addresses { get; set; }
	}
}
