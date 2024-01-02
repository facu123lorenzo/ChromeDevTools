using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.SystemInfo
{
	/// <summary>
	///Returns information about the feature state.

	/// </summary>
	[Command(ProtocolName.SystemInfo.GetFeatureState)]
	[SupportedBy("Chrome")]
	public class GetFeatureStateCommand: ICommand<GetFeatureStateCommandResponse>
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string FeatureState { get; set; }
	}
}
