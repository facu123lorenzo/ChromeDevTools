using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Audits
{
	/// <summary>
	///This issue tracks client hints related issues. It's used to deprecate old
	/// features, encourage the use of new ones, and provide general guidance.

	/// </summary>
	[SupportedBy("Chrome")]
	public class ClientHintIssueDetails
	{
		/// <summary>
		/// Gets or sets

		/// </summary>
		public SourceCodeLocation SourceCodeLocation { get; set; }
		/// <summary>
		/// Gets or sets

		/// </summary>
		public ClientHintIssueReason ClientHintIssueReason { get; set; }
	}
}
