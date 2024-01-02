using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///An object providing the result of a network resource load.

	/// </summary>
	[SupportedBy("Chrome")]
	public class LoadNetworkResourcePageResult
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool Success { get; set; }
		/// <summary>
		/// Gets or setsOptional values used for error reporting.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double NetError { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string NetErrorName { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public double HttpStatusCode { get; set; }
		/// <summary>
		/// Gets or setsIf successful, one of the following two fields holds the result.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Stream { get; set; }
		/// <summary>
		/// Gets or setsResponse headers.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Dictionary<string, string> Headers { get; set; }
	}
}
