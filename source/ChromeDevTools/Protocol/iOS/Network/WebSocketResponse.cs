using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.iOS.Network
{
	/// <summary>
	///WebSocket response data.

	/// </summary>
	[SupportedBy("iOS")]
	public class WebSocketResponse
	{
		/// <summary>
		/// Gets or setsHTTP response status code.

		/// </summary>
		public double Status { get; set; }
		/// <summary>
		/// Gets or setsHTTP response status text.

		/// </summary>
		public string StatusText { get; set; }
		/// <summary>
		/// Gets or setsHTTP response headers.

		/// </summary>
		public Dictionary<string, string> Headers { get; set; }
	}
}
