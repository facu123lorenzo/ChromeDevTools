using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Information about a signed exchange response.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedExchangeInfo
	{
		/// <summary>
		/// Gets or setsThe outer response of signed HTTP exchange which was received from network.

		/// </summary>
		public Response OuterResponse { get; set; }
		/// <summary>
		/// Gets or setsInformation about the signed exchange header.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SignedExchangeHeader Header { get; set; }
		/// <summary>
		/// Gets or setsSecurity details for the signed exchange header.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SecurityDetails SecurityDetails { get; set; }
		/// <summary>
		/// Gets or setsErrors occurred while handling the signed exchagne.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SignedExchangeError[] Errors { get; set; }
	}
}
