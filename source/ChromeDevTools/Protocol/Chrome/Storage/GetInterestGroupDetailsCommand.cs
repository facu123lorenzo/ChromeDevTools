using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Gets details for a named interest group.

	/// </summary>
	[Command(ProtocolName.Storage.GetInterestGroupDetails)]
	[SupportedBy("Chrome")]
	public class GetInterestGroupDetailsCommand: ICommand<GetInterestGroupDetailsCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string OwnerOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string Name { get; set; }
	}
}
