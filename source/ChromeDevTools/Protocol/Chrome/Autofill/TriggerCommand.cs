using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Autofill
{
	/// <summary>
	///Trigger autofill on a form identified by the fieldId.
	/// If the field and related form cannot be autofilled, returns an error.

	/// </summary>
	[Command(ProtocolName.Autofill.Trigger)]
	[SupportedBy("Chrome")]
	public class TriggerCommand: ICommand<TriggerCommandResponse>
	{
		/// <summary>
		/// Gets or setsIdentifies a field that serves as an anchor for autofill.

		/// </summary>
		public long FieldId { get; set; }
		/// <summary>
		/// Gets or setsIdentifies the frame that field belongs to.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or setsCredit card information to fill out the form. Credit card data is not saved.

		/// </summary>
		public CreditCard Card { get; set; }
	}
}
