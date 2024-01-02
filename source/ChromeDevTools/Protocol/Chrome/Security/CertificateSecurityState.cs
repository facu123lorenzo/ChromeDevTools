using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Security
{
	/// <summary>
	///Details about the security state of the page certificate.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CertificateSecurityState
	{
		/// <summary>
		/// Gets or setsProtocol name (e.g. "TLS 1.2" or "QUIC").

		/// </summary>
		public string Protocol { get; set; }
		/// <summary>
		/// Gets or setsKey Exchange used by the connection, or the empty string if not applicable.

		/// </summary>
		public string KeyExchange { get; set; }
		/// <summary>
		/// Gets or sets(EC)DH group used by the connection, if applicable.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string KeyExchangeGroup { get; set; }
		/// <summary>
		/// Gets or setsCipher name.

		/// </summary>
		public string Cipher { get; set; }
		/// <summary>
		/// Gets or setsTLS MAC. Note that AEAD ciphers do not have separate MACs.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string Mac { get; set; }
		/// <summary>
		/// Gets or setsPage certificate.

		/// </summary>
		public string[] Certificate { get; set; }
		/// <summary>
		/// Gets or setsCertificate subject name.

		/// </summary>
		public string SubjectName { get; set; }
		/// <summary>
		/// Gets or setsName of the issuing CA.

		/// </summary>
		public string Issuer { get; set; }
		/// <summary>
		/// Gets or setsCertificate valid from date.

		/// </summary>
		public double ValidFrom { get; set; }
		/// <summary>
		/// Gets or setsCertificate valid to (expiration) date

		/// </summary>
		public double ValidTo { get; set; }
		/// <summary>
		/// Gets or setsThe highest priority network error code, if the certificate has an error.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string CertificateNetworkError { get; set; }
		/// <summary>
		/// Gets or setsTrue if the certificate uses a weak signature aglorithm.

		/// </summary>
		public bool CertificateHasWeakSignature { get; set; }
		/// <summary>
		/// Gets or setsTrue if the certificate has a SHA1 signature in the chain.

		/// </summary>
		public bool CertificateHasSha1Signature { get; set; }
		/// <summary>
		/// Gets or setsTrue if modern SSL

		/// </summary>
		public bool ModernSSL { get; set; }
		/// <summary>
		/// Gets or setsTrue if the connection is using an obsolete SSL protocol.

		/// </summary>
		public bool ObsoleteSslProtocol { get; set; }
		/// <summary>
		/// Gets or setsTrue if the connection is using an obsolete SSL key exchange.

		/// </summary>
		public bool ObsoleteSslKeyExchange { get; set; }
		/// <summary>
		/// Gets or setsTrue if the connection is using an obsolete SSL cipher.

		/// </summary>
		public bool ObsoleteSslCipher { get; set; }
		/// <summary>
		/// Gets or setsTrue if the connection is using an obsolete SSL signature.

		/// </summary>
		public bool ObsoleteSslSignature { get; set; }
	}
}
