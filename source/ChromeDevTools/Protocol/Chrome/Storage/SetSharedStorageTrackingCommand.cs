using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Enables/disables issuing of sharedStorageAccessed events.

	/// </summary>
	[Command(ProtocolName.Storage.SetSharedStorageTracking)]
	[SupportedBy("Chrome")]
	public class SetSharedStorageTrackingCommand: ICommand<SetSharedStorageTrackingCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Enable { get; set; }
	}
}
