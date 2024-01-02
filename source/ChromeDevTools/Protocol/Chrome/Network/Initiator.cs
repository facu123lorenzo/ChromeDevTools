using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Information about the request initiator.

	/// </summary>
	[SupportedBy("Chrome")]
	public class Initiator
	{
		/// <summary>
		/// Gets or setsType of this initiator.

		/// </summary>
		public string Type { get; set; }
		/// <summary>
		/// Gets or setsInitiator JavaScript stack trace, set for Script only.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Runtime.StackTrace Stack { get; set; }
		/// <summary>
		/// Gets or setsInitiator URL, set for Parser type or for Script type (when script is importing module) or for SignedExchange type.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Url { get; set; }
		/// <summary>
		/// Gets or setsInitiator line number, set for Parser type or for Script type (when script is importing
		/// module) (0-based).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or setsInitiator column number, set for Parser type or for Script type (when script is importing
		/// module) (0-based).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double ColumnNumber { get; set; }
		/// <summary>
		/// Gets or setsSet if another request triggered this request (e.g. preflight).

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string RequestId { get; set; }
	}
}
