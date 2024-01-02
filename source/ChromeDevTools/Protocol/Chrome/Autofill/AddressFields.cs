using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///A list of address fields.

	/// </summary>
	[SupportedBy("Chrome")]
	public class AddressFields
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AddressField[] Fields { get; set; }
	}
}
