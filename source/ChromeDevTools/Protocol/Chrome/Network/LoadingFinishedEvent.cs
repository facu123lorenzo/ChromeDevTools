using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Fired when HTTP request has finished loading.

	/// </summary>
	[Event(ProtocolName.Network.LoadingFinished)]
	[SupportedBy("Chrome")]
	public class LoadingFinishedEvent
	{
		/// <summary>
		/// Gets or setsRequest identifier.

		/// </summary>
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or setsTimestamp.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsTotal number of bytes received for this request.

		/// </summary>
		public double EncodedDataLength { get; set; }
	}
}
