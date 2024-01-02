using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Network
{
	/// <summary>
	///Details of a signed certificate timestamp (SCT).

	/// </summary>
	[SupportedBy("Chrome")]
	public class SignedCertificateTimestamp
	{
		/// <summary>
		/// Gets or setsValidation status.

		/// </summary>
		public string Status { get; set; }
		/// <summary>
		/// Gets or setsOrigin.

		/// </summary>
		public string Origin { get; set; }
		/// <summary>
		/// Gets or setsLog name / description.

		/// </summary>
		public string LogDescription { get; set; }
		/// <summary>
		/// Gets or setsLog ID.

		/// </summary>
		public string LogId { get; set; }
		/// <summary>
		/// Gets or setsIssuance date. Unlike TimeSinceEpoch, this contains the number of
		/// milliseconds since January 1, 1970, UTC, not the number of seconds.

		/// </summary>
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or setsHash algorithm.

		/// </summary>
		public string HashAlgorithm { get; set; }
		/// <summary>
		/// Gets or setsSignature algorithm.

		/// </summary>
		public string SignatureAlgorithm { get; set; }
		/// <summary>
		/// Gets or setsSignature data.

		/// </summary>
		public string SignatureData { get; set; }
	}
}
