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
	[CommandResponse(ProtocolName.Autofill.Trigger)]
	[SupportedBy("Chrome")]
	public class TriggerCommandResponse
	{
	}
}
