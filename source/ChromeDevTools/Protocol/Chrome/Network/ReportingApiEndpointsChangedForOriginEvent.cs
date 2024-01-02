using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	[Event(ProtocolName.Network.ReportingApiEndpointsChangedForOrigin)]
	[SupportedBy("Chrome")]
	public class ReportingApiEndpointsChangedForOriginEvent
	{
		/// <summary>
		/// Gets or setsOrigin of the document(s) which configured the endpoints.

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ReportingApiEndpoint[] Endpoints { get; set; }
	}
}
