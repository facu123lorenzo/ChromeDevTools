using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Security details about a request.

	/// </summary>
	[SupportedBy("Chrome")]
	public class SecurityDetails
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
		/// Gets or setsCertificate ID value.

		/// </summary>
		public long CertificateId { get; set; }
		/// <summary>
		/// Gets or setsCertificate subject name.

		/// </summary>
		public string SubjectName { get; set; }
		/// <summary>
		/// Gets or setsSubject Alternative Name (SAN) DNS names and IP addresses.

		/// </summary>
		public string[] SanList { get; set; }
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
		/// Gets or setsList of signed certificate timestamps (SCTs).

		/// </summary>
		public SignedCertificateTimestamp[] SignedCertificateTimestampList { get; set; }
		/// <summary>
		/// Gets or setsWhether the request complied with Certificate Transparency policy

		/// </summary>
		public CertificateTransparencyCompliance CertificateTransparencyCompliance { get; set; }
		/// <summary>
		/// Gets or setsThe signature algorithm used by the server in the TLS server signature,
		/// represented as a TLS SignatureScheme code point. Omitted if not
		/// applicable or not known.

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public long? ServerSignatureAlgorithm { get; set; }
		/// <summary>
		/// Gets or setsWhether the connection used Encrypted ClientHello

		/// </summary>
		public bool EncryptedClientHello { get; set; }
	}
}
