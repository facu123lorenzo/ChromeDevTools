using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[SupportedBy("Chrome")]
	public class ClientSecurityState
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool InitiatorIsSecureContext { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public IPAddressSpace InitiatorIPAddressSpace { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public PrivateNetworkRequestPolicy PrivateNetworkRequestPolicy { get; set; }
	}
}
