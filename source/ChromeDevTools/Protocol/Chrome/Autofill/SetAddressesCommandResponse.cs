using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///Set addresses so that developers can verify their forms implementation.

	/// </summary>
	[CommandResponse(ProtocolName.Autofill.SetAddresses)]
	[SupportedBy("Chrome")]
	public class SetAddressesCommandResponse
	{
	}
}
