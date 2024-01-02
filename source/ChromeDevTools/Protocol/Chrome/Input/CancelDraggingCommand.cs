using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Input
{
	/// <summary>
	///Cancels any active dragging in the page.

	/// </summary>
	[Command(ProtocolName.Input.CancelDragging)]
	[SupportedBy("Chrome")]
	public class CancelDraggingCommand: ICommand<CancelDraggingCommandResponse>
	{
	}
}
