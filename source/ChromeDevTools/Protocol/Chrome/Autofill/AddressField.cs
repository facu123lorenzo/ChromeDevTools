using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	[SupportedBy("Chrome")]
	public class AddressField
	{
		/// <summary>
		/// Gets or setsaddress field name, for example GIVEN_NAME.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsaddress field value, for example Jon Doe.

		/// </summary>
		public string Value { get; set; }
	}
}
