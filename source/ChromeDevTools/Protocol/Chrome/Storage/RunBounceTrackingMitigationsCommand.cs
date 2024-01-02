using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Deletes state for sites identified as potential bounce trackers, immediately.

	/// </summary>
	[Command(ProtocolName.Storage.RunBounceTrackingMitigations)]
	[SupportedBy("Chrome")]
	public class RunBounceTrackingMitigationsCommand: ICommand<RunBounceTrackingMitigationsCommandResponse>
	{
	}
}
