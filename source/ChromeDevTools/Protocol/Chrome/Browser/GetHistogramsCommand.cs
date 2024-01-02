using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Get Chrome histograms.

	/// </summary>
	[Command(ProtocolName.Browser.GetHistograms)]
	[SupportedBy("Chrome")]
	public class GetHistogramsCommand: ICommand<GetHistogramsCommandResponse>
	{
		/// <summary>
		/// Gets or setsRequested substring in name. Only histograms which have query as a
		/// substring in their name are extracted. An empty or absent query returns
		/// all histograms.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Query { get; set; }
		/// <summary>
		/// Gets or setsIf true, retrieve delta since last delta call.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Delta { get; set; }
	}
}
