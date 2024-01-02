using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Browser
{
	/// <summary>
	///Get a Chrome histogram by name.

	/// </summary>
	[Command(ProtocolName.Browser.GetHistogram)]
	[SupportedBy("Chrome")]
	public class GetHistogramCommand: ICommand<GetHistogramCommandResponse>
	{
		/// <summary>
		/// Gets or setsRequested histogram name.

		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// Gets or setsIf true, retrieve delta since last delta call.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public bool? Delta { get; set; }
	}
}
