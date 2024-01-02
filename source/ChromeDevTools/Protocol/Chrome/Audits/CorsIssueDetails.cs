using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///Details for a CORS related issue, e.g. a warning or error related to
	/// CORS RFC1918 enforcement.

	/// </summary>
	[SupportedBy("Chrome")]
	public class CorsIssueDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public Network.CorsErrorStatus CorsErrorStatus { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public bool IsWarning { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public AffectedRequest Request { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public SourceCodeLocation Location { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string InitiatorOrigin { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.IPAddressSpace ResourceIPAddressSpace { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public Network.ClientSecurityState ClientSecurityState { get; set; }
	}
}