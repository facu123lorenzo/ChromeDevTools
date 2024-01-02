using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.FedCm
{
	/// <summary>
	///Triggered when a dialog is closed, either by user action, JS abort,
	/// or a command below.

	/// </summary>
	[Event(ProtocolName.FedCm.DialogClosed)]
	[SupportedBy("Chrome")]
	public class DialogClosedEvent
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string DialogId { get; set; }
	}
}
