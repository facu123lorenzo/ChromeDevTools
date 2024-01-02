using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Resets the budget for `ownerOrigin` by clearing all budget withdrawals.

	/// </summary>
	[Command(ProtocolName.Storage.ResetSharedStorageBudget)]
	[SupportedBy("Chrome")]
	public class ResetSharedStorageBudgetCommand: ICommand<ResetSharedStorageBudgetCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string OwnerOrigin { get; set; }
	}
}
