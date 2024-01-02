using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Storage
{
	/// <summary>
	///Pair of issuer origin and number of available (signed, but not used) Trust
	/// Tokens from that issuer.

	/// </summary>
	[SupportedBy("Chrome")]
	public class TrustTokens
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public string IssuerOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public double Count { get; set; }
	}
}
