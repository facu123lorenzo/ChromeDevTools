using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///Emitted when an address form is filled.

	/// </summary>
	[Event(ProtocolName.Autofill.AddressFormFilled)]
	[SupportedBy("Chrome")]
	public class AddressFormFilledEvent
	{
		/// <summary>
		/// Gets or setsInformation about the fields that were filled

		/// </summary>
		public FilledField[] FilledFields { get; set; }
		/// <summary>
		/// Gets or setsAn UI representation of the address used to fill the form.
		/// Consists of a 2D array where each child represents an address/profile line.

		/// </summary>
		public AddressUI AddressUi { get; set; }
	}
}
