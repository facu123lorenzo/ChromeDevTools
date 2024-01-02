using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	[SupportedBy("Chrome")]
	public class Address
	{
		/// <summary>
		/// Gets or setsfields and values defining an address.

		/// </summary>
		public AddressField[] Fields { get; set; }
	}
}
