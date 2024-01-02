using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Information about a signed exchange header.
	/// https://wicg.github.io/webpackage/draft-yasskin-httpbis-origin-signed-exchanges-impl.html#cbor-representation

	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedExchangeHeader
	{
		/// <summary>
		/// Gets or setsSigned exchange request URL.

		/// </summary>
		public string RequestUrl { get; set; }
		/// <summary>
		/// Gets or setsSigned exchange response code.

		/// </summary>
		public long ResponseCode { get; set; }
		/// <summary>
		/// Gets or setsSigned exchange response headers.

		/// </summary>
		public Dictionary<string, string> ResponseHeaders { get; set; }
		/// <summary>
		/// Gets or setsSigned exchange response signature.

		/// </summary>
		public SignedExchangeSignature[] Signatures { get; set; }
		/// <summary>
		/// Gets or setsSigned exchange header integrity hash in the form of `sha256-<base64-hash-value>`.

		/// </summary>
		public string HeaderIntegrity { get; set; }
	}
}
